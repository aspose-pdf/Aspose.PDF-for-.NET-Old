Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices
Imports System.Drawing
Namespace AsposePDF.Images
    Public Class ImageToPDF
        Public Shared Sub Run()
            ' ExStart:ImageToPDF         
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Instantiate Document Object
            Dim doc As New Document()
            ' Add a page to pages collection of document
            Dim page As Page = doc.Pages.Add()
            ' Load the source image file to Stream object
            Dim fs As New FileStream(dataDir & Convert.ToString("aspose-logo.jpg"), FileMode.Open, FileAccess.Read)
            Dim tmpBytes(fs.Length) As Byte
            fs.Read(tmpBytes, 0, Convert.ToInt32(fs.Length))

            Dim mystream As MemoryStream = New MemoryStream(tmpBytes)
            ' Instantiate BitMap object with loaded image stream
            Dim b As Bitmap = New Bitmap(mystream)

            ' Set margins so image will fit, etc.
            page.PageInfo.Margin.Bottom = 0
            page.PageInfo.Margin.Top = 0
            page.PageInfo.Margin.Left = 0
            page.PageInfo.Margin.Right = 0

            page.CropBox = New Rectangle(0, 0, b.Width, b.Height)
            ' Create an image object
            Dim image1 As Image = New Image()
            ' Add the image into paragraphs collection of the section
            page.Paragraphs.Add(image1)
            ' Set the image file stream
            image1.ImageStream = mystream

            dataDir = dataDir & Convert.ToString("ImageToPDF_out_.pdf")
            ' Save resultant PDF file
            doc.Save(dataDir)

            ' Close memoryStream object
            mystream.Close()
            ' ExEnd:ImageToPDF   
            Console.WriteLine(Convert.ToString(vbLf & "Image converted to pdf successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
