Imports System.IO
Imports System
Imports System.Web
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateArrayOfFilesWithPath
        Public Shared Sub Run()
            ' ExStart:ConcatenateArrayOfFilesWithPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Array of files
            Dim filesArray As String() = New String(1) {}
            filesArray(0) = dataDir & Convert.ToString("input.pdf")
            filesArray(1) = dataDir & Convert.ToString("input2.pdf")
            ' Concatenate files
            pdfEditor.Concatenate(filesArray, dataDir & Convert.ToString("ConcatenateArrayOfFilesWithPath_out_.pdf"))
            ' ExEnd:ConcatenateArrayOfFilesWithPath
        End Sub
        Public Shared Sub RenderInBrowser()
            ' ExStart:RenderInBrowser
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Array of files
            Dim filesArray As String() = New String(1) {}
            filesArray(0) = dataDir & Convert.ToString("input.pdf")
            filesArray(1) = dataDir & Convert.ToString("input2.pdf")
            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Display the resultant concatenated PDF file in 
            pdfEditor.Concatenate(filesArray, dataDir & Convert.ToString("RenderInBrowser_out_.pdf"))
            ' ExEnd:RenderInBrowser
        End Sub

        Public Shared Sub CorruptedFiles()
            ' ExStart:CorruptedFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            Dim pfe As New Aspose.Pdf.Facades.PdfFileEditor()
            pfe.CorruptedFileAction = Aspose.Pdf.Facades.PdfFileEditor.ConcatenateCorruptedFileAction.ConcatenateIgnoringCorrupted
            pfe.Concatenate(New String() {dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("input2.pdf"), dataDir & Convert.ToString("input3.pdf")}, dataDir & Convert.ToString("CorruptedFiles_out_.pdf"))
            If pfe.CorruptedItems.Length > 0 Then
                Console.WriteLine("Corrupted documents:")
                For Each item As Aspose.Pdf.Facades.PdfFileEditor.CorruptedItem In pfe.CorruptedItems
                    Console.WriteLine(item.Index.ToString() + " reason " + item.Exception.Message)
                Next
            Else

                Console.WriteLine("No corrupted documents")
            End If
            ' ExEnd:CorruptedFiles
        End Sub
    End Class
End Namespace
