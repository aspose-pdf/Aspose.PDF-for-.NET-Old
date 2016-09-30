Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PdfFileEditorFeatures
        Public Shared Sub Run()
            ' ExStart:PdfFileEditorFeatures
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create instance of PdfFileEditor class
            Dim pdfEditor As New PdfFileEditor()

            ' Append pages from input file to the port file and save in output file
            Dim start As Integer = 1
            Dim [end] As Integer = 3
            pdfEditor.Append(dataDir & Convert.ToString("inFile.pdf"), dataDir & Convert.ToString("portFile.pdf"), start, [end], dataDir & Convert.ToString("outFile.pdf"))

            ' Concatenate two files and save in the third one
            pdfEditor.Concatenate(dataDir & Convert.ToString("inFile1.pdf"), dataDir & Convert.ToString("inFile2.pdf"), dataDir & Convert.ToString("outFile.pdf"))

            ' Delete specified number of pages from the file
            Dim pages As Integer() = New Integer() {1, 2, 4, 10}
            pdfEditor.Delete(dataDir & Convert.ToString("inFile.pdf"), pages, dataDir & Convert.ToString("outFile.pdf"))

            ' Extract any pages from the file
            start = 0
            [end] = 3
            pdfEditor.OwnerPassword = "ownerpass"
            pdfEditor.Extract(dataDir & Convert.ToString("inFile.pdf"), start, [end], dataDir & Convert.ToString("outFile.pdf"))

            ' Insert pages from another file into the output file at a specified position
            start = 2
            [end] = 5
            pdfEditor.Insert(dataDir & Convert.ToString("inFile.pdf"), 4, dataDir & Convert.ToString("portFile.pdf"), start, [end], dataDir & Convert.ToString("outFile.pdf"))

            ' Make booklet
            pdfEditor.MakeBooklet(dataDir & Convert.ToString("inFile.Pdf"), dataDir & Convert.ToString("outFile.Pdf"))

            ' Make N-Ups
            pdfEditor.MakeNUp(dataDir & Convert.ToString("inFile.pdf"), dataDir & Convert.ToString("nupOutFile.pdf"), 3, 2)

            ' Split the front part of the file
            pdfEditor.SplitFromFirst(dataDir & Convert.ToString("inFile.pdf"), 3, dataDir & Convert.ToString("outFile.pdf"))

            ' Split the rear part of the file
            pdfEditor.SplitToEnd(dataDir & Convert.ToString("inFile.pdf"), 3, dataDir & Convert.ToString("outFile.pdf"))

            ' Split to individual pages
            Dim fileNum As Integer = 1
            Dim outBuffer As MemoryStream() = pdfEditor.SplitToPages(dataDir & Convert.ToString("inFile.pdf"))
            For Each aStream As MemoryStream In outBuffer
                Dim outStream As New FileStream("oneByone" + fileNum.ToString() + ".pdf", FileMode.Create)
                aStream.WriteTo(outStream)
                outStream.Close()
                fileNum += 1
            Next

            ' Split to several multi-page pdf documents
            fileNum = 1
            Dim numberofpage As Integer()() = New Integer()() {New Integer() {1, 4}}
            Dim outBuffer2 As MemoryStream() = pdfEditor.SplitToBulks(dataDir & Convert.ToString("inFile.pdf"), numberofpage)
            For Each aStream As MemoryStream In outBuffer2
                Dim outStream As New FileStream("oneByone" + fileNum.ToString() + ".pdf", FileMode.Create)
                aStream.WriteTo(outStream)
                outStream.Close()
                fileNum += 1
            Next
            ' ExEnd:PdfFileEditorFeatures                      
        End Sub
    End Class
End Namespace
