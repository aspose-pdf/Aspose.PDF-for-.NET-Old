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
    Public Class Render
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'Create a section in the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            'Add a text paragraph in the section
            sec1.Paragraphs.Add(New Aspose.Pdf.Generator.Text("page 1"))

            'Create another text paragraph that has to be rendered
            Dim t2 As New Aspose.Pdf.Generator.Text("page2")

            'Set the IsFirstParagraph property of the text paragraph to true
            'to render it to a new page
            t2.IsFirstParagraph = True

            'Add the text paragraph to be rendered to the section
            sec1.Paragraphs.Add(t2)

            'Save the Pdf document
            pdf1.Save(dataDir & "HelloWorld.pdf")


        End Sub
    End Class
End Namespace