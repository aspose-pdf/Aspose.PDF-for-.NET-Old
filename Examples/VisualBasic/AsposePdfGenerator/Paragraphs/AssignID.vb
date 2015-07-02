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

Namespace VisualBasic.AsposePdfGenerator.Paragraphs
    Public Class AssignID
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs()
            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'Add a new section to the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            'Create a text paragraph with the reference of a section, sec1
            Dim text3 As New Aspose.Pdf.Generator.Text(sec1, "product 1 info ...")

            'Add the text paragraph in the section
            sec1.Paragraphs.Add(text3)

            'Set the text paragraph to be the first paragraph among the other ones
            text3.IsFirstParagraph = True

            'Assign and ID to the text paragraph
            text3.ID = "product1"

            ' save the resultant PDF
            pdf1.Save(dataDir & "ParaID.pdf")

        End Sub
    End Class
End Namespace