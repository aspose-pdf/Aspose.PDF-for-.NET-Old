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

Namespace VisualBasic.AsposePdf.Attachments
    Public Class DisableFilesCompression
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim pdfDocument As New Document(dataDir & "Input.pdf")
            'Setup new file to be added as attachment
            Dim fileSpecification As New FileSpecification("test.txt", "Sample text file")
            'Specify Encoding proparty setting it to FileEncoding.None
            fileSpecification.Encoding = FileEncoding.None
            'Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification)
            'Save new output
            pdfDocument.Save(dataDir & "DisableFilesCompression_out.pdf")





        End Sub
    End Class
End Namespace