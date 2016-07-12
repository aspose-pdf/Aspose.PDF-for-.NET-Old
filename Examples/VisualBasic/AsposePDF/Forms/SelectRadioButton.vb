Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Namespace AsposePDF.Forms
    Public Class SelectRadioButton
        Public Shared Sub Run()
            Try
                ' ExStart:SelectRadioButton
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()
                ' Open document
                Dim pdfDocument As New Document(dataDir & Convert.ToString("RadioButton.pdf"))
                ' Get a field
                Dim radioField As RadioButtonField = TryCast(pdfDocument.Form("radio"), RadioButtonField)
                ' Specify the index of radio button from group
                radioField.Selected = 2

                dataDir = dataDir & Convert.ToString("SelectRadioButton_out_.pdf")
                ' Save the PDF file
                pdfDocument.Save(dataDir)
                ' ExEnd:SelectRadioButton
                Console.WriteLine(Convert.ToString(vbLf & "RadioButton from group selected successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace
