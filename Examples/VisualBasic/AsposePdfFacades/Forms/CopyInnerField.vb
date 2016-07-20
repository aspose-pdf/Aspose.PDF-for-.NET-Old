Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class CopyInnerField
        Public Shared Sub Run()
            Try
                ' ExStart:CopyInnerField
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()
                ' Create FormEditor object
                Dim formEditor As New FormEditor()
                ' Open Document
                formEditor.BindPdf(dataDir & "CopyInnerField.pdf")
                ' Copy a field to another page
                formEditor.CopyInnerField("textfield", "newfieldname", 1)

                ' Close and save the output document
                formEditor.Save(dataDir & "CopyInnerField_out_.pdf")
                ' ExEnd:CopyInnerField
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace

