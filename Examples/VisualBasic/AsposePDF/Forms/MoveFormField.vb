Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class MoveFormField
        Public Shared Sub Run()
            ' ExStart:MoveFormField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("MoveFormField.pdf"))

            ' Get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            ' Modify field location
            textBoxField.Rect = New Rectangle(300, 400, 600, 500)

            dataDir = dataDir & Convert.ToString("MoveFormField_out_.pdf")
            ' Save modified document
            pdfDocument.Save(dataDir)
            ' ExEnd:MoveFormField
            Console.WriteLine(Convert.ToString(vbLf & "Form field moved successfully to a new location." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
