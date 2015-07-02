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
Imports System

Namespace VisualBasic.AsposePdf.Annotations
    Public Class GetParticularAnnotation
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            'open document
            Dim pdfDocument As New Document(dataDir & "GetParticularAnnotation.pdf")

            'get particular annotation
            Dim textAnnotation As TextAnnotation = CType(pdfDocument.Pages(1).Annotations(1), TextAnnotation)

            'get annotation properties
            Console.WriteLine("Title : {0} ", textAnnotation.Title)
            Console.WriteLine("Subject : {0} ", textAnnotation.Subject)
            Console.WriteLine("Contents : {0} ", textAnnotation.Contents)

        End Sub
    End Class
End Namespace