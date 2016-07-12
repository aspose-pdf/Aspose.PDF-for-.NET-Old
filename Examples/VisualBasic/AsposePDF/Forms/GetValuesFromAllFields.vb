Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class GetValuesFromAllFields
        Public Shared Sub Run()
            ' ExStart:GetValuesFromAllFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetValuesFromAllFields.pdf"))

            ' Get values from all fields
            For Each formField As Field In pdfDocument.Form
                Console.WriteLine("Field Name : {0} ", formField.PartialName)
                Console.WriteLine("Value : {0} ", formField.Value)
            Next
            ' ExEnd:GetValuesFromAllFields
        End Sub
    End Class
End Namespace

