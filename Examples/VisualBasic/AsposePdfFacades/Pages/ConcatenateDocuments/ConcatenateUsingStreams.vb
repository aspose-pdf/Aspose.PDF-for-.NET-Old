Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateUsingStreams
        Public Shared Sub Run()
            ' ExStart:ConcatenateUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Output stream
            Dim outputStream As New FileStream(dataDir & Convert.ToString("ConcatenateUsingStreams_out_.pdf"), FileMode.Create)
            ' Input streams
            Dim inputStream1 As New FileStream(dataDir & Convert.ToString("test.pdf"), FileMode.Open)
            Dim inputStream2 As New FileStream(dataDir & Convert.ToString("input5.pdf"), FileMode.Open)
            ' Concatenate file
            pdfEditor.Concatenate(inputStream1, inputStream2, outputStream)
            inputStream1.Flush()
            inputStream2.Flush()
            inputStream1.Close()
            inputStream2.Close()
            ' ExEnd:ConcatenateUsingStreams
        End Sub
        Public Shared Sub ConcatenateTaggedFiles()
            ' ExStart:ConcatenateTaggedFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            Dim fileInputStream1 As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open, FileAccess.Read)
            Dim fileInputStream2 As New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open, FileAccess.Read)
            Dim fileOutputStream As New FileStream(dataDir & Convert.ToString("ConcatenateTaggedFiles_out_.pdf"), FileMode.Create, FileAccess.Write)
            ' Concatenate files
            Dim editor As New PdfFileEditor()
            editor.CopyLogicalStructure = True
            Dim success As Boolean = editor.Concatenate(fileInputStream1, fileInputStream2, fileOutputStream)
            Console.Out.WriteLine("Successful... " + success.ToString())
            ' Close the streams
            fileOutputStream.Close()
            fileInputStream1.Close()
            fileInputStream2.Close()

            ' ExEnd:ConcatenateTaggedFiles

        End Sub
    End Class
End Namespace
