Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms
Namespace AsposePDF.Forms
    Public Class DynamicXFAToAcroForm
        Public Shared Sub Run()
            ' ExStart:DynamicXFAToAcroForm
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load dynamic XFA form
            Dim document As New Document(dataDir & Convert.ToString("DynamicXFAToAcroForm.pdf"))

            ' Set the form fields type as standard AcroForm
            document.Form.Type = FormType.Standard

            dataDir = dataDir & Convert.ToString("Standard_AcroForm_out_.pdf")
            ' Save the resultant PDF
            document.Save(dataDir)
            ' ExEnd:DynamicXFAToAcroForm
            Console.WriteLine(Convert.ToString(vbLf & "Dynamic XFA form converted to standard AcroForm successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
