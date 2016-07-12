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
Imports Aspose.Pdf.Annotations
Imports System.Collections

Namespace AsposePDFFacades.Annotations
    Public Class ExtractAnnotations
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            'create PdfAnnotationEditor
            Dim annotationEditor As New PdfAnnotationEditor()
            'open PDF document
            annotationEditor.BindPdf(dataDir & "ExtractAnnotations.pdf")
            'extract annotations
            Dim annotType() As System.Enum = {AnnotationType.FreeText, AnnotationType.Line}
            Dim annotList As ArrayList = CType(annotationEditor.ExtractAnnotations(1, 2, annotType), ArrayList)
            For index As Integer = 0 To annotList.Count - 1
                Dim annotation As Annotation = CType(annotList(index), Annotation)
                Console.WriteLine(annotation.Contents)
            Next index

        End Sub
    End Class
End Namespace