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
Imports Aspose.Pdf.InteractiveFeatures

Namespace VisualBasic.AsposePdf.Annotations
    Public Class SetFreeTextAnnotationFormatting
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            'open document
            Dim pdfDocument As New Document(dataDir & "SetFreeTextAnnotationFormatting.pdf")

            ' instantiate DefaultAppearance object
            Dim default_appearance As Aspose.Pdf.InteractiveFeatures.DefaultAppearance = New DefaultAppearance("Arial", 28, System.Drawing.Color.Red)

            'create annotation
            Dim freetext As New FreeTextAnnotation(pdfDocument.Pages(1), New Aspose.Pdf.Rectangle(200, 400, 400, 600), default_appearance)

            ' specify the contents of annotation
            freetext.Contents = "Free Text"

            ' add anootation to annotations collection of page
            pdfDocument.Pages(1).Annotations.Add(freetext)

            ' save the updated document
            pdfDocument.Save(dataDir & "SetFreeTextAnnotationFormatting_out.pdf")


        End Sub
    End Class
End Namespace