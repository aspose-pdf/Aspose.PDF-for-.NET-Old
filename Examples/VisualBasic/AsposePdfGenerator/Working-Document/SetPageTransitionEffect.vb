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
    Public Class SetPageTransitionEffect
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Pdf instance
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'You may set OpenType poperty to full screen
            pdf1.OpenType = Aspose.Pdf.Generator.OpenType.FullScreen

            'Set PageTransitionType poperty of Pdf instance to a pre-defined desired value
            pdf1.PageTransitionType = Aspose.Pdf.Generator.PageTransitionType.Dissolve
            pdf1.Save(dataDir & "PageTransition.pdf")

        End Sub
    End Class
End Namespace