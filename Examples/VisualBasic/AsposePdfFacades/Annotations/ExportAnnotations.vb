'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System
Imports Aspose.Pdf.InteractiveFeatures.Annotations

Namespace VisualBasic.AsposePDFFacades.Annotations
    Public Class ExportAnnotations
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            'create PdfAnnotationEditor object
            Dim AnnotationEditor As New PdfAnnotationEditor()
            'open PDF document
            AnnotationEditor.BindPdf(dataDir & "ExportAnnotations.pdf")
            'import annotations
            Dim fileStream As FileStream = New System.IO.FileStream(dataDir & "annotations.xfdf", System.IO.FileMode.Create)
            Dim annotType() As System.Enum = {AnnotationType.FreeText, AnnotationType.Line}
            AnnotationEditor.ExportAnnotationsXfdf(fileStream, 1, 5, annotType)
            'save output PDF
            AnnotationEditor.Save(dataDir & "ExportAnnotations_out.pdf")


        End Sub
    End Class
End Namespace