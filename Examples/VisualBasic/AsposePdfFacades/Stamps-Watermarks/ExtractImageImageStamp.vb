Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class ExtractImageImageStamp
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractImageImageStamp
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()
                ' Instantiate PdfContentEditor Object
                Dim pdfContentEditor As New PdfContentEditor()

                ' Bind input PDF file
                pdfContentEditor.BindPdf(dataDir & Convert.ToString("ExtractImage-ImageStamp.pdf"))

                ' Get Stamp info for the first stamp
                Dim infos As StampInfo() = pdfContentEditor.GetStamps(1)

                ' Get the image from Stamp Info           
                Dim image As System.Drawing.Image = infos(0).Image

                ' Save the extracted image
                ' ExEnd:ExtractImageImageStamp  
                image.Save(dataDir & Convert.ToString("image_out_.jpg"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace