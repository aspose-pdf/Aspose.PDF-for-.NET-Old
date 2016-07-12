Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Images
    Public Class ReplaceImage
        Public Shared Sub Run()
            ' ExStart:ReplaceImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ReplaceImage.pdf"))

            ' Replace a particular image
            pdfDocument.Pages(1).Resources.Images.Replace(1, New FileStream(dataDir & Convert.ToString("aspose-logo.jpg"), FileMode.Open))

            dataDir = dataDir & Convert.ToString("ReplaceImage_out_.pdf")
            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:ReplaceImage
            Console.WriteLine(Convert.ToString(vbLf & "Image replaced successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace