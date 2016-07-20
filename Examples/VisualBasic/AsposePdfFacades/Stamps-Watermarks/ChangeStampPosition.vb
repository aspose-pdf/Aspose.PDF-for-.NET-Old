Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class ChangeStampPosition
        Public Shared Sub Run()
            Try
                ' ExStart:ChangeStampPosition
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

                ' Instantiate PdfContentEditor Object
                Dim pdfContentEditor As New PdfContentEditor()

                ' Bind input PDF file
                pdfContentEditor.BindPdf(dataDir & Convert.ToString("ChangeStampPosition.pdf"))

                Dim pageId As Integer = 1
                Dim stampIndex As Integer = 1
                Dim x As Double = 200
                Dim y As Double = 200

                ' Change the position of the stamp to new x and y position
                pdfContentEditor.MoveStamp(pageId, stampIndex, x, y)

                ' Save the Pdf file
                ' ExEnd:ChangeStampPosition
                pdfContentEditor.Save(dataDir & Convert.ToString("ChangeStampPosition_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace