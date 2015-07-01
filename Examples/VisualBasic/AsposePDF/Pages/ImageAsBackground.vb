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

Namespace VisualBasic.AsposePdf.Pages
    Public Class ImageAsBackground
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' create a new Document object
            Dim doc As New Document()

            ' add a new page to document object
            Dim page As Page = doc.Pages.Add()

            ' create BackgroundArtifact object
            Dim background As New BackgroundArtifact()

            ' specify the image for backgroundartifact object
            background.BackgroundImage = File.OpenRead(dataDir & "aspose-total-for-net.jpg")

            ' add backgroundartifact to artifacts collection of page
            page.Artifacts.Add(background)

            ' save the document
            doc.Save(dataDir & "ImageAsBackground_out.pdf")

        End Sub
    End Class
End Namespace