Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class ArabicTextFilling
        Public Shared Sub Run()
            ' ExStart:ArabicTextFilling
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load PDF form contents
            Dim fs As New FileStream(dataDir & Convert.ToString("FillFormField.pdf"), FileMode.Open, FileAccess.ReadWrite)
            ' Instantiate Document instance with stream holding form file
            Dim pdfDocument As New Document(fs)
            ' Get referecne of particuarl TextBoxField
            Dim txtFld As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)
            ' Fill form field with arabic text
            txtFld.Value = "يولد جميع الناس أحراراً متساوين في"

            dataDir = dataDir & Convert.ToString("ArabicTextFilling_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:ArabicTextFilling
            Console.WriteLine(Convert.ToString(vbLf & "Arabic text filled successfully in form field." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
