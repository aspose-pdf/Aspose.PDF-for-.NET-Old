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

Namespace VisualBasic.AsposePdf.DocumentConversion
    Public Class PCLToPDF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' instantiate LoadOption object using PCL load option
            Dim loadopt As Aspose.Pdf.LoadOptions = New Aspose.Pdf.PclLoadOptions()

            ' create Document object
            Dim doc As New Aspose.Pdf.Document(dataDir & "test.pcl", loadopt)

            ' save the resultant PDF document
            doc.Save(dataDir & "test-converted.pdf")
        End Sub
    End Class
End Namespace