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
Imports Aspose.Pdf.Text

Namespace VisualBasic.AsposePdf.Forms
    Public Class FormFieldFont14
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & "FormFieldFont14.pdf")

            ' Get particular form field from document
            Dim field As Aspose.Pdf.InteractiveFeatures.Forms.Field = TryCast(pdfDocument.Form("textbox1"), Aspose.Pdf.InteractiveFeatures.Forms.Field)

            ' Create font object
            Dim font As Aspose.Pdf.Text.Font = FontRepository.FindFont("ComicSansMS")

            ' Set the font information for form field
            field.DefaultAppearance = New Aspose.Pdf.InteractiveFeatures.DefaultAppearance(font, 10, System.Drawing.Color.Black)

            ' Save updated document
            pdfDocument.Save(dataDir & "FormFieldFont14_out.pdf")
        End Sub
    End Class
End Namespace