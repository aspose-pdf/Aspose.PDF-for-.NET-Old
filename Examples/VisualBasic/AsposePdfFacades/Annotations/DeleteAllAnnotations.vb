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

Namespace VisualBasic.AsposePDFFacades.Annotations
    Public Class DeleteAllAnnotations
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            'open document
            Dim annotationEditor As New PdfAnnotationEditor()
            annotationEditor.BindPdf(dataDir & "DeleteAllAnnotations.pdf")
            'delete all annoations
            annotationEditor.DeleteAnnotations("Text")
            'save updated PDF
            annotationEditor.Save(dataDir & "DeleteAllAnnotations_out.pdf")

        End Sub
    End Class
End Namespace