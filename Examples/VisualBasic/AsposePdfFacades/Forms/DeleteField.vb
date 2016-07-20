Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class DeleteField
        Public Shared Sub Run()
            ' ExStart:DeleteField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim formEditor As New FormEditor()
            ' Open Document
            formEditor.BindPdf(dataDir & Convert.ToString("DeleteFormField.pdf"))

            ' Delete field
            formEditor.RemoveField("textfield")
            ' Save updated file
            formEditor.Save(dataDir & Convert.ToString("DeleteFormField_out_.pdf"))
            ' ExEnd:DeleteField
        End Sub
    End Class
End Namespace

