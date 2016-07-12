Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFToXLS
        Public Shared Sub Run()
            ' ExStart:PDFToXLS
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Instantiate ExcelSave Option object
            Dim excelsave As ExcelSaveOptions = New ExcelSaveOptions()

            ' Save the output in XLS format
            pdfDocument.Save("PDFToXLS_out_.xls", excelsave)
            ' ExEnd:PDFToXLS
        End Sub
        Public Shared Sub ControlColumn()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

            ' ExStart:ControlColumn
            ' Instantiate ExcelSave Option object
            Dim excelsave As ExcelSaveOptions = New ExcelSaveOptions()
            excelsave.InsertBlankColumnAtFirst = False
            ' ExEnd:ControlColumn

            ' Save the output in XLS format
            pdfDocument.Save("PDFToXLSControlColumn_out_.xls", excelsave)
        End Sub
        Public Shared Sub ExportAllPagesToSingle()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

            ' ExStart:ExportAllPagesToSingle
            ' Instantiate ExcelSave Option object
            Dim excelsave As ExcelSaveOptions = New ExcelSaveOptions()
            ' Set this property to true
            excelsave.MinimizeTheNumberOfWorksheets = True
            ' ExEnd:ExportAllPagesToSingle

            ' Save the output in XLS format
            pdfDocument.Save("PDFToXLSExportAllPagesToSingle_out_.xls", excelsave)
        End Sub
    End Class
End Namespace