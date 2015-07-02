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

Namespace VisualBasic.AsposePdf.LinksActions
    Public Class AddHyperlink
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()


            ' Open document
            Dim document As New Document(dataDir & "AddHyperlink.pdf")
            ' Create link
            Dim page As Page = document.Pages(1)
            ' Create Link annotation object
            Dim link As New Aspose.Pdf.InteractiveFeatures.Annotations.LinkAnnotation(page, New Aspose.Pdf.Rectangle(100, 100, 300, 300))
            ' Create border object for LinkAnnotation
            Dim border As New Aspose.Pdf.InteractiveFeatures.Annotations.Border(link)
            ' Set the border width value as 0
            border.Width = 0
            ' Set the border for LinkAnnotation
            link.Border = border
            ' Specify the link type as remote URI
            link.Action = New Aspose.Pdf.InteractiveFeatures.GoToURIAction("www.aspose.com")
            ' Add link annotation to annotations collection of first page of PDF file
            page.Annotations.Add(link)

            ' Create Free Text annotation
            Dim textAnnotation As New Aspose.Pdf.InteractiveFeatures.Annotations.FreeTextAnnotation(document.Pages(1), New Aspose.Pdf.Rectangle(100, 100, 300, 300), New Aspose.Pdf.InteractiveFeatures.DefaultAppearance(Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman"), 10, System.Drawing.Color.Blue))
            ' String to be added as Free text
            textAnnotation.Contents = "Link to Aspose website"
            ' Set the border for Free Text Annotation
            textAnnotation.Border = border
            ' Add FreeText annotation to annotations collection of first page of Document
            document.Pages(1).Annotations.Add(textAnnotation)
            ' Save updated document
            document.Save(dataDir & "AddHyperlink_out.pdf")

        End Sub
    End Class
End Namespace