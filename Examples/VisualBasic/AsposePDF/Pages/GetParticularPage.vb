Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class GetParticularPage
        Public Shared Sub Run()
            ' ExStart:GetParticularPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetParticularPage.pdf"))

            ' Get particular page
            Dim pdfPage As Page = pdfDocument.Pages(2)

            ' Save the page as PDF file
            Dim newDocument As New Document()

            newDocument.Pages.Add(pdfPage)

            dataDir = dataDir & Convert.ToString("GetParticularPage_out_.pdf")
            newDocument.Save(dataDir)
            ' ExEnd:GetParticularPage
            System.Console.WriteLine(Convert.ToString(vbLf & "Particular page accessed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

