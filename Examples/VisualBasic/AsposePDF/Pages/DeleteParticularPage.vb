Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class DeleteParticularPage
        Public Shared Sub Run()
            ' ExStart:DeleteParticularPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteParticularPage.pdf"))

            ' Delete a particular page
            pdfDocument.Pages.Delete(2)

            dataDir = dataDir & Convert.ToString("DeleteParticularPage_out_.pdf")
            ' Save updated PDF
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteParticularPage
            System.Console.WriteLine(Convert.ToString(vbLf & "Particular page deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
