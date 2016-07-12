Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Images
    Public Class DeleteImages
        Public Shared Sub Run()
            ' ExStart:DeleteImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteImages.pdf"))

            ' Delete a particular image
            pdfDocument.Pages(1).Resources.Images.Delete(1)

            dataDir = dataDir & Convert.ToString("DeleteImages_out_.pdf")
            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteImages
            Console.WriteLine(Convert.ToString(vbLf & "Images deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
