Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class SetJSPushButton
        Public Shared Sub Run()
            ' ExStart:SetJSPushButton
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Set JavaScript
            form.SetFieldScript("pushbutton", "app.alert('Hello World!');")
            ' Save update document
            form.Save(dataDir & Convert.ToString("SetJSPushButton_out_.pdf"))
            ' ExEnd:SetJSPushButton
        End Sub
    End Class
End Namespace

