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

Namespace VisualBasic.AsposePDFFacades.Images
    Public Class DeleteImagesPage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            'open PDF file
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "DeleteImages-Page.pdf")

            'array of images to be deleted
            Dim imageIndex() As Integer = {1}

            'delete the images from the particular page
            contentEditor.DeleteImage(2, imageIndex)

            'save output PDF
            contentEditor.Save(dataDir & "DeleteImages-Page_out.pdf")



        End Sub
    End Class
End Namespace