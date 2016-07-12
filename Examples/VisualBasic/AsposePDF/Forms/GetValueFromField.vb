Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.Forms
    Public Class GetValueFromField
        Public Shared Sub Run()
            ' ExStart:GetValueFromField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetValueFromField.pdf"))

            ' Get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            ' Get field value
            Console.WriteLine("PartialName : {0} ", textBoxField.PartialName)
            Console.WriteLine("Value : {0} ", textBoxField.Value)
            ' ExEnd:GetValueFromField
        End Sub
        Public Shared Sub GetSubmitButtonURL()
            ' ExStart:GetSubmitButtonURL
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetValueFromField.pdf"))
            Dim act As SubmitFormAction = TryCast(pdfDocument.Form(1).OnActivated, SubmitFormAction)
            If act IsNot Nothing Then
                Console.WriteLine(act.Url.Name)
            End If
            ' ExEnd:GetSubmitButtonURL
        End Sub
    End Class
End Namespace
