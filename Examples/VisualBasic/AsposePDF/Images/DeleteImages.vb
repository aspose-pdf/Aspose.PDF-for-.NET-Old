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

Namespace VisualBasic.AsposePdf.Images
    Public Class DeleteImages
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            'open document
            Dim pdfDocument As New Document(dataDir & "DeleteImages.pdf")

            'delete a particular image
            pdfDocument.Pages(1).Resources.Images.Delete(1)

            'save updated PDF file
            pdfDocument.Save(dataDir & "DeleteImages_out.pdf")


        End Sub
    End Class
End Namespace