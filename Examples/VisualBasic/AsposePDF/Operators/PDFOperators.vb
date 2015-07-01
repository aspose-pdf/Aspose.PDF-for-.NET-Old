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
Imports Aspose.Pdf.DOM

Namespace VB.AsposePdf.Operators
    Public Class PDFOperators
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Operators()

            'open document
            Dim pdfDocument As New Document(dataDir & "PDFOperators.pdf")

            'set coordinates
            Dim lowerLeftX As Integer = 100
            Dim lowerLeftY As Integer = 100
            Dim upperRightX As Integer = 200
            Dim upperRightY As Integer = 200

            'get the page where image needs to be added
            Dim page As Page = pdfDocument.Pages(1)
            'load image into stream
            Dim imageStream As New FileStream(dataDir & "aspose-logo.jpg", FileMode.Open)
            'add image to Images collection of Page Resources
            page.Resources.Images.Add(imageStream)
            'using GSave operator: this operator saves current graphics state
			page.Contents.Add(New Operator.GSave())
            'create Rectangle and Matrix objects
            Dim rectangle As New Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY)
            Dim matrix As New Matrix(New Double() {rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY})
            'using ConcatenateMatrix (concatenate matrix) operator: defines how image must be placed
			page.Contents.Add(New Operator.ConcatenateMatrix(matrix))
            Dim ximage As XImage = page.Resources.Images(page.Resources.Images.Count)
            'using Do operator: this operator draws image
			page.Contents.Add(New Operator.Do(ximage.Name))
            'using GRestore operator: this operator restores graphics state
			page.Contents.Add(New Operator.GRestore())
            'save updated document
            pdfDocument.Save(dataDir & "PDFOperators_out.pdf")


        End Sub
    End Class
End Namespace