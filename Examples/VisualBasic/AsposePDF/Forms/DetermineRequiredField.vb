Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports APF = Aspose.Pdf.Facades
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class DetermineRequiredField
        Public Shared Sub Run()
            ' ExStart:DetermineRequiredField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load source PDF file
            Dim pdf As New Document(dataDir & Convert.ToString("DetermineRequiredField.pdf"))

            ' Instantiate Form object
            Dim pdfForm As New APF.Form(pdf)

            ' Iterate through each field inside PDF form
            For Each field As Field In pdf.Form.Fields
                ' Determine if the field is marked as required or not
                Dim isRequired As Boolean = pdfForm.IsRequiredField(field.FullName)
                If isRequired Then
                    ' Print either the field is marked as required or not
                    Console.WriteLine("The field named " + field.FullName + " is required")
                End If
            Next
            ' ExEnd:DetermineRequiredField
        End Sub
    End Class
End Namespace
