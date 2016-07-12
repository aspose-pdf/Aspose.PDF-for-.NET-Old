Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Forms
    Public Class SetJavaScript
        Public Shared Sub Run()
            ' ExStart:SetJavaScript
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load input PDF file
            Dim doc As New Document(dataDir & Convert.ToString("SetJavaScript.pdf"))

            Dim field As TextBoxField = DirectCast(doc.Form("textbox1"), TextBoxField)

            ' 2 digits after point
            ' No separator
            ' Neg style = minus
            ' No currency
            field.Actions.OnModifyCharacter = New JavascriptAction("AFNumber_Keystroke(2, 1, 1, 0, """", true)")
            field.Actions.OnFormat = New JavascriptAction("AFNumber_Format(2, 1, 1, 0, """", true)")

            ' Set initial field value
            field.Value = "123"

            dataDir = dataDir & Convert.ToString("Restricted_out_.pdf")
            ' Save resultant PDF
            doc.Save(dataDir)
            ' ExEnd:SetJavaScript
            Console.WriteLine(Convert.ToString(vbLf & "JavaScript on form field setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
