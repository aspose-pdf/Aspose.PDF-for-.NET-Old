Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFToDOC
        Public Shared Sub Run()
            ' ExStart:PDFToDOC
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' open the source PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToDOC.pdf"))

            ' Save the file into MS document format
            pdfDocument.Save(dataDir & Convert.ToString("PDFToDOC_out_.doc"), SaveFormat.Doc)
            ' ExEnd:PDFToDOC        

        End Sub
        Public Shared Sub SaveUsingSaveOptions()
            ' ExStart:SaveUsingSaveOptions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Open the source PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToDOC.pdf"))

            ' Save using save options
            ' Create DocSaveOptions object
            Dim saveOptions As New DocSaveOptions()

            ' Set the recognition mode as Flow
            saveOptions.Mode = DocSaveOptions.RecognitionMode.Flow

            ' Set the Horizontal proximity as 2.5
            saveOptions.RelativeHorizontalProximity = 2.5F

            ' Enable the value to recognize bullets during conversion process
            saveOptions.RecognizeBullets = True

            ' Save the resultant DOC file
            pdfDocument.Save(dataDir & Convert.ToString("saveOptionsOutput_out_.doc"), saveOptions)
            ' ExEnd:SaveUsingSaveOptions
        End Sub
        Public Shared Sub ConvertToDOCX()
            ' ExStart:ConvertToDOCX
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Open the source PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToDOC.pdf"))

            ' Instantiate DocSaveOptions object
            Dim saveOptions As New DocSaveOptions()
            ' Specify the output format as DOCX
            saveOptions.Format = DocSaveOptions.DocFormat.DocX
            ' Save document in docx format
            pdfDocument.Save("ConvertToDOCX_out_.docx", saveOptions)
            ' ExEnd:ConvertToDOCX
        End Sub
    End Class
End Namespace
