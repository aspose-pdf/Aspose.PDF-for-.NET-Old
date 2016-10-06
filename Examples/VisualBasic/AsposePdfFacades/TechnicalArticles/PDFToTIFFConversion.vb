Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Devices
Imports Aspose.Pdf.Annotations
Imports System.Drawing

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PDFToTIFFConversion
        Public Shared Sub Run()
            ' ExStart:PDFToTIFFConversion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfConverter object and bind input PDF file
            Dim pdfConverter As New PdfConverter()
            pdfConverter.Resolution = New Aspose.Pdf.Devices.Resolution(300)
            pdfConverter.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            pdfConverter.DoConvert()
            ' Create TiffSettings object and set ColorDepth
            Dim tiffSettings As New TiffSettings()
            tiffSettings.Depth = ColorDepth.Format1bpp
            ' Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir & Convert.ToString("PDFToTIFFConversion_out_.tif"), 300, 300, tiffSettings)
            pdfConverter.Close()
            ' ExEnd:PDFToTIFFConversion                      
        End Sub
        Public Shared Sub NewApproach()
            ' ExStart:NewApproach
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfConverter object and bind input PDF file
            Dim pdfConverter As New PdfConverter()
            pdfConverter.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            pdfConverter.DoConvert()

            ' Create TiffSettings object and set CompressionType
            Dim tiffSettings As New TiffSettings()
            ' Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir & Convert.ToString("PDFToTIFFConversion_out_.tif"), 300, 300, tiffSettings, New WinAPIIndexBitmapConverter())
            pdfConverter.Close()
            ' ExEnd:NewApproach                      
        End Sub
    End Class
    ' ExStart:IIndexBitmapConverter
    Public Class WinAPIIndexBitmapConverter
        Implements IIndexBitmapConverter
        Public Function Get1BppImage(ByVal src As Bitmap) As Bitmap Implements IIndexBitmapConverter.Get1BppImage
            Return CopyToBpp(src, 1)
        End Function

        Public Function Get4BppImage(ByVal src As Bitmap) As Bitmap Implements IIndexBitmapConverter.Get4BppImage
            Return CopyToBpp(src, 4)
        End Function

        Public Function Get8BppImage(ByVal src As Bitmap) As Bitmap Implements IIndexBitmapConverter.Get8BppImage
            Return CopyToBpp(src, 8)
        End Function


        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Public Shared Function DeleteObject(hObject As IntPtr) As Boolean
        End Function

        <System.Runtime.InteropServices.DllImport("user32.dll")> _
        Public Shared Function GetDC(hwnd As IntPtr) As IntPtr
        End Function

        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Public Shared Function CreateCompatibleDC(hdc As IntPtr) As IntPtr
        End Function

        <System.Runtime.InteropServices.DllImport("user32.dll")> _
        Public Shared Function ReleaseDC(hwnd As IntPtr, hdc As IntPtr) As Integer
        End Function

        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Public Shared Function DeleteDC(hdc As IntPtr) As Integer
        End Function

        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Public Shared Function SelectObject(hdc As IntPtr, hgdiobj As IntPtr) As IntPtr
        End Function

        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Public Shared Function BitBlt(hdcDst As IntPtr, xDst As Integer, yDst As Integer, w As Integer, h As Integer, hdcSrc As IntPtr, _
            xSrc As Integer, ySrc As Integer, rop As Integer) As Integer
        End Function
        Shared SRCCOPY As Integer = &HCC0020

        <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
        Private Shared Function CreateDIBSection(hdc As IntPtr, ByRef bmi As BITMAPINFO, Usage As UInteger, ByRef bits As IntPtr, hSection As IntPtr, dwOffset As UInteger) As IntPtr
        End Function
        Shared BI_RGB As UInteger = 0
        Shared DIB_RGB_COLORS As UInteger = 0
        <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)> _
        Public Structure BITMAPINFO
            Public biSize As UInteger
            Public biWidth As Integer, biHeight As Integer
            Public biPlanes As Short, biBitCount As Short
            Public biCompression As UInteger, biSizeImage As UInteger
            Public biXPelsPerMeter As Integer, biYPelsPerMeter As Integer
            Public biClrUsed As UInteger, biClrImportant As UInteger
            <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=256)> _
            Public cols As UInteger()
        End Structure

        Private Shared Function MAKERGB(r As Integer, g As Integer, b As Integer) As UInteger
            Return CUInt(b And 255) Or CUInt((r And 255) << 8) Or CUInt((g And 255) << 16)
        End Function

        '''/////////
        ''' <summary>
        ''' Copies a bitmap into a 1bpp/8bpp bitmap of the same dimensions, fast
        ''' </summary>
        ''' <param name="b">original bitmap</param>
        ''' <param name="bpp">1 or 8, target bpp</param>
        ''' <returns>a 1bpp copy of the bitmap</returns>
        Private Function CopyToBpp(b As System.Drawing.Bitmap, bpp As Integer) As Bitmap
            If bpp <> 1 AndAlso bpp <> 8 AndAlso bpp <> 4 Then
                Throw New System.ArgumentException("1 or 4 or 8 ", "bpp")
            End If

            ' Plan: built into Windows GDI is the ability to convert
            ' bitmaps from one format to another. Most of the time, this
            ' job is actually done by the graphics hardware accelerator card
            ' and so is extremely fast. The rest of the time, the job is done by
            ' very fast native code.
            ' We will call into this GDI functionality from C#. Our plan:
            ' (1) Convert our Bitmap into a GDI hbitmap (ie. copy unmanaged->managed)
            ' (2) Create a GDI monochrome hbitmap
            ' (3) Use GDI "BitBlt" function to copy from hbitmap into monochrome (as above)
            ' (4) Convert the monochrone hbitmap into a Bitmap (ie. copy unmanaged->managed)

            Dim w As Integer = b.Width, h As Integer = b.Height
            Dim hbm As IntPtr = b.GetHbitmap()
            ' this is step (1)
            '
            ' Step (2): create the monochrome bitmap.
            ' "BITMAPINFO" is an interop-struct which we define below.
            ' In GDI terms, it's a BITMAPHEADERINFO followed by an array of two RGBQUADs
            Dim bmi As New BITMAPINFO()
            bmi.biSize = 40
            ' the size of the BITMAPHEADERINFO struct
            bmi.biWidth = w
            bmi.biHeight = h
            bmi.biPlanes = 1
            ' "planes" are confusing. We always use just 1. Read MSDN for more info.
            bmi.biBitCount = CShort(bpp)
            ' ie. 1bpp or 8bpp
            bmi.biCompression = BI_RGB
            ' ie. the pixels in our RGBQUAD table are stored as RGBs, not palette indexes
            bmi.biSizeImage = CUInt(((w + 7) And &HFFFFFFF8UI) * h / 8)
            bmi.biXPelsPerMeter = 1000000
            ' not really important
            bmi.biYPelsPerMeter = 1000000
            ' not really important
            ' Now for the colour table.
            Dim ncols As UInteger = CUInt(1) << bpp
            ' 2 colours for 1bpp; 256 colours for 8bpp
            bmi.biClrUsed = ncols
            bmi.biClrImportant = ncols
            bmi.cols = New UInteger(255) {}
            ' The structure always has fixed size 256, even if we end up using fewer colours
            If bpp = 1 Then
                bmi.cols(0) = MAKERGB(0, 0, 0)
                bmi.cols(1) = MAKERGB(255, 255, 255)
            ElseIf bpp = 4 Then
                ' For 8bpp we've created an palette with just greyscale colours.
                ' You can set up any palette you want here. Here are some possibilities:
                ' rainbow: 
                bmi.biClrUsed = 16
                bmi.biClrImportant = 16
                Dim colv As Integer() = New Integer(15) {8, 24, 38, 56, 72, 88, _
                    104, 120, 136, 152, 168, 184, _
                    210, 216, 232, 248}
                '          
                For i As Integer = 0 To 15
                    bmi.cols(i) = MAKERGB(colv(i), colv(i), colv(i))
                Next
            ElseIf bpp = 8 Then
                ' For 8bpp we've created an palette with just greyscale colours.
                ' You can set up any palette you want here. Here are some possibilities:
                ' rainbow:
                bmi.biClrUsed = 216
                bmi.biClrImportant = 216
                Dim colv As Integer() = New Integer(5) {0, 51, 102, 153, 204, 255}
                For i As Integer = 0 To 215
                    bmi.cols(i) = MAKERGB(colv(Convert.ToInt32(i / 36)), colv(Convert.ToInt32((i / 6) Mod 6)), colv(i Mod 6))
                    ' optimal: a difficult topic: http://en.wikipedia.org/wiki/Color_quantization
                Next
            End If


            ' 
            ' Now create the indexed bitmap "hbm0"
            Dim bits0 As IntPtr
            ' not used for our purposes. It returns a pointer to the raw bits that make up the bitmap.
            Dim hbm0 As IntPtr = CreateDIBSection(IntPtr.Zero, bmi, DIB_RGB_COLORS, bits0, IntPtr.Zero, 0)
            '
            ' Step (3): use GDI's BitBlt function to copy from original hbitmap into monocrhome bitmap
            ' GDI programming is kind of confusing... nb. The GDI equivalent of "Graphics" is called a "DC".
            Dim sdc As IntPtr = GetDC(IntPtr.Zero)
            ' First we obtain the DC for the screen
            ' Next, create a DC for the original hbitmap
            Dim hdc As IntPtr = CreateCompatibleDC(sdc)
            SelectObject(hdc, hbm)
            ' and create a DC for the monochrome hbitmap
            Dim hdc0 As IntPtr = CreateCompatibleDC(sdc)
            SelectObject(hdc0, hbm0)
            ' Now we can do the BitBlt:
            BitBlt(hdc0, 0, 0, w, h, hdc, _
                0, 0, SRCCOPY)
            ' Step (4): convert this monochrome hbitmap back into a Bitmap:
            Dim b0 As Bitmap = System.Drawing.Image.FromHbitmap(hbm0)
            '
            ' Finally some cleanup.
            DeleteDC(hdc)
            DeleteDC(hdc0)
            ReleaseDC(IntPtr.Zero, sdc)
            DeleteObject(hbm)
            DeleteObject(hbm0)
            '
            Return b0
        End Function
    End Class
    ' ExEnd:IIndexBitmapConverter
End Namespace
