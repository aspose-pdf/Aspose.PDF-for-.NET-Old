Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class CopyOuterField
        Public Shared Sub Run()
            Try
                ' ExStart:CopyOuterField
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

                ' Open document
                Dim formEditor As New FormEditor()

                ' Open the document and create a FormEditor object
                formEditor.BindPdf(dataDir & "CopyOuterField.pdf")

                ' Copy a text field from one document to another one
                formEditor.CopyOuterField(dataDir & Convert.ToString("input.pdf"), "textfield", 1)

                ' Close and save the output document
                formEditor.Save(dataDir & Convert.ToString("CopyOuterField_out_.pdf"))
                ' ExEnd:CopyOuterField
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace

