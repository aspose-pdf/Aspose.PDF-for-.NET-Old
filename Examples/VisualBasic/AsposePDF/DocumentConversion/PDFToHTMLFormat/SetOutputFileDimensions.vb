Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SetOutputFileDimensions
        Public Shared Sub Run()
            Try
                ' ExStart:SetOutputFileDimensions
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                ' Select desirable page size
                Dim newPageWidth As Single = 400.0F
                Dim newPageHeight As Single = 400.0F

                ' Tune PdfPageEditor class 
                Dim pdfEditor As New Facades.PdfPageEditor()
                ' Bind source PDF file
                pdfEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))
                ' Set the page dimensions 
                pdfEditor.PageSize = New PageSize(newPageWidth, newPageHeight)
                ' Set vertical alignment for page as center aligned
                pdfEditor.VerticalAlignmentType = VerticalAlignment.Center
                ' Set Horizontal alignment for page as center aligned
                pdfEditor.HorizontalAlignment = HorizontalAlignment.Center

                ' This scales page content to fit width,
                ' Comment it out or set Zoom to 1.0F if You don't want to scale
                ' Content and only want to change page's size (i.e. crop it)
                Dim zoom As Single = Math.Min(CSng(newPageWidth) / CSng(pdfEditor.Document.Pages(1).Rect.Width), CSng(newPageHeight) / CSng(pdfEditor.Document.Pages(1).Rect.Height))
                pdfEditor.Zoom = zoom
                ' (float)595;
                ' Create stream object to hold file with updated dimensions
                Dim output As New MemoryStream()
                ' Save file to stream object
                pdfEditor.Save(output)

                ' Then reload scaled document and save it to HTML
                Dim exportDoc As New Document(output)
                Dim htmlOptions As New HtmlSaveOptions()
                ' This code shows page boreder in result - sometimes it comes in handy to see borders
                Dim borderStyle As New SaveOptions.BorderPartStyle()
                borderStyle.LineType = SaveOptions.HtmlBorderLineType.Dotted
                borderStyle.Color = System.Drawing.Color.Gray
                htmlOptions.PageBorderIfAny = New SaveOptions.BorderInfo(borderStyle)

                ' Conversion to HTML itself
                exportDoc.Save(dataDir & Convert.ToString("SetOutputFileDimensions_out_.html"), htmlOptions)
                ' Close the stream object
                ' ExEnd:SetOutputFileDimensions
                output.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
