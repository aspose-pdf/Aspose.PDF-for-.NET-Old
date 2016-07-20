Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class MoveField
        Public Shared Sub Run()
            ' ExStart:MoveField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim formEditor As New FormEditor()
            ' Open Document
            formEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Move field to new location
            formEditor.MoveField("textfield", 300, 300, 400, 400)
            ' Save updated file
            formEditor.Save(dataDir & Convert.ToString("MoveFormField_out_.pdf"))
            ' ExEnd:MoveField
        End Sub
    End Class
End Namespace
