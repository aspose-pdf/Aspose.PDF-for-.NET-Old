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

Namespace VisualBasic.AsposePdfGenerator.WorkingDocuments
    Public Class AddingXMPMetaData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If


            'Instantiate a PDF Object 
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            'Add a section into the pdf document
            Dim section1 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' create a sample text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text("This is a test for XMP Metadata")
            ' Add text paragraph to paragraphs collection of section object
            section1.Paragraphs.Add(text1)

            ' create XmpMetaData object
            pdf.XmpMetadata = New Aspose.Pdf.Generator.XmpMetadata()

            'core properties
            pdf.XmpMetadata.AddCreationDate(System.DateTime.Now.ToString())

            'user properties
            pdf.XmpMetadata.AddUserProperty("xmlns:dc=""http://purl.org/dc/elements/1.1/""", "dc:contributor", "Aspose")

            'Save Pdf Document
            pdf.Save(dataDir & "Aspose.pdf")


        End Sub
    End Class
End Namespace