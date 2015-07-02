'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports Aspose.Pdf.InteractiveFeatures

Namespace VisualBasic.AsposePdf.Forms
    Public Class SetJavaScript
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' load input PDF file
            Dim doc As New Document(dataDir & "SetJavaScript.pdf")

            Dim field As TextBoxField = CType(doc.Form("textbox1"), TextBoxField)

            '2 digits after point
            'no separator
            'neg style = minus
            'no currency
            field.Actions.OnModifyCharacter = New JavascriptAction("AFNumber_Keystroke(2, 1, 1, 0, """", true)")
            field.Actions.OnFormat = New JavascriptAction("AFNumber_Format(2, 1, 1, 0, """", true)")

            ' set initial field value
            field.Value = "123"

            ' save resultant PDF
            doc.Save(dataDir & "Restricted_out.pdf")

        End Sub
    End Class
End Namespace