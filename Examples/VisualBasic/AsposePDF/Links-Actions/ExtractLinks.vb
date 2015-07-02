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
Imports Aspose.Pdf.InteractiveFeatures.Annotations
Imports System.Collections

Namespace VisualBasic.AsposePdf.LinksActions
    Public Class ExtractLinks
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()


            'Open document
            Dim document As New Document(dataDir & "ExtractLinks.pdf")

            'Extract actions
            Dim page As Page = document.Pages(1)
            Dim selector As New AnnotationSelector(New LinkAnnotation(page, Aspose.Pdf.Rectangle.Trivial))
            page.Accept(selector)
            Dim list As IList = selector.Selected

            Dim annotation As Annotation = CType(list(0), Annotation)

            'Save updated document
            document.Save(dataDir & "ExtractLinks_out.pdf")

        End Sub
    End Class
End Namespace