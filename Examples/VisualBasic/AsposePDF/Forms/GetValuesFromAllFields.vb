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
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports System

Namespace VisualBasic.AsposePdf.Forms
    Public Class GetValuesFromAllFields
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            'open document
            Dim pdfDocument As New Document(dataDir & "GetValuesFromAllFields.pdf")

            'get values from all fields
            For Each formField As Field In pdfDocument.Form
                Console.WriteLine("Field Name : {0} ", formField.PartialName)
                Console.WriteLine("Value : {0} ", formField.Value)
            Next formField

        End Sub
    End Class
End Namespace