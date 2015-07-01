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

Namespace VisualBasic.AsposePdfGenerator.Text
    Public Class UnderlineOverlineStrikeOut
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            'Create 1st text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "Text underline")

            'Set IsUnderline property of Text.TextInfo to true
            text1.TextInfo.IsUnderline = True

            'Create 2nd text paragraph
            Dim text2 As New Aspose.Pdf.Generator.Text(sec1, "Text overline")

            'Set IsOverline property of Text.TextInfo to true
            text2.TextInfo.IsOverline = True

            'Create 3rd text paragraph
            Dim text3 As New Aspose.Pdf.Generator.Text(sec1, "Text strike out")

            'Set IsStrikeOut property of Text.TextInfo to true
            text3.TextInfo.IsStrikeOut = True

            'Add 1st, 2nd and 3rd text paragraphs to the section
            sec1.Paragraphs.Add(text1)
            sec1.Paragraphs.Add(text2)
            sec1.Paragraphs.Add(text3)

            'Save the Pdf
            pdf1.Save(dataDir & "Output.pdf")


        End Sub
    End Class
End Namespace