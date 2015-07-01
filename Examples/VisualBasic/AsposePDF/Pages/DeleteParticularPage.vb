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
    Public Class DeleteParticularPage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            'open document
            Dim pdfDocument As New Document(dataDir & "DeleteParticularPage.pdf")

            'delete a particular page
            pdfDocument.Pages.Delete(2)

            'save updated PDF
            pdfDocument.Save(dataDir & "DeleteParticularPage_out.pdf")

        End Sub
    End Class
End Namespace