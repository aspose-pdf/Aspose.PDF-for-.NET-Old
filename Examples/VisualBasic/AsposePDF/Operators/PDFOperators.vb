Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports AP = Aspose.Pdf
Namespace AsposePDF.Operators
    Public Class PDFOperators
        Public Shared Sub Run()
            ' ExStart:PDFOperators
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Operators()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFOperators.pdf"))

            ' Set coordinates
            Dim lowerLeftX As Integer = 100
            Dim lowerLeftY As Integer = 100
            Dim upperRightX As Integer = 200
            Dim upperRightY As Integer = 200

            ' Get the page where image needs to be added
            Dim page As Page = pdfDocument.Pages(1)
            ' Load image into stream
            Dim imageStream As New FileStream(dataDir & Convert.ToString("aspose-logo.jpg"), FileMode.Open)
            ' Add image to Images collection of Page Resources
            page.Resources.Images.Add(imageStream)
            ' Using GSave operator: this operator saves current graphics state
            page.Contents.Add(New AP.Operator.GSave())
            ' Create Rectangle and Matrix objects
            Dim rectangle As New Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY)
            Dim matrix As New Matrix(New Double() {rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY})
            ' Using ConcatenateMatrix (concatenate matrix) operator: defines how image must be placed
            page.Contents.Add(New AP.Operator.ConcatenateMatrix(matrix))
            Dim ximage As XImage = page.Resources.Images(page.Resources.Images.Count)
            ' Using Do operator: this operator draws image
            page.Contents.Add(New AP.Operator.Do(ximage.Name))
            ' Using GRestore operator: this operator restores graphics state
            page.Contents.Add(New AP.Operator.GRestore())
            dataDir = dataDir & Convert.ToString("PDFOperators_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:PDFOperators            
        End Sub
    End Class
End Namespace