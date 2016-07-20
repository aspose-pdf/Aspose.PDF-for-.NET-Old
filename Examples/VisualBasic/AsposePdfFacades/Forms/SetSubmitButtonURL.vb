Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class SetSubmitButtonURL
        Public Shared Sub Run()
            ' ExStart:SetSubmitButtonURL
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Set submit URL
            form.SetSubmitUrl("submitbutton", "http://www.aspose.com")
            ' Save update document
            form.Save(dataDir & Convert.ToString("SetSubmitButtonURL_out_.pdf"))
            ' ExEnd:SetSubmitButtonURL
        End Sub
    End Class
End Namespace
