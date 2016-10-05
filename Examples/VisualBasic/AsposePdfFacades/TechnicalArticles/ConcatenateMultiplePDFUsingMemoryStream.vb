Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ConcatenateMultiplePDFUsingMemoryStream
        Public Shared Sub Run()
            ' ExStart:ConcatenateMultiplePDFUsingMemoryStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create two file streams to read pdf files
            Dim fs1 As New FileStream(dataDir & Convert.ToString("inFile.pdf"), FileMode.Open, FileAccess.Read)
            Dim fs2 As New FileStream(dataDir & Convert.ToString("inFile2.pdf"), FileMode.Open, FileAccess.Read)

            ' Create byte arrays to keep the contents of PDF files
            Dim buffer1 As Byte() = New Byte(Convert.ToInt32(fs1.Length) - 1) {}
            Dim buffer2 As Byte() = New Byte(Convert.ToInt32(fs2.Length) - 1) {}


            Dim i As Integer = 0
            ' Read PDF file contents into byte arrays
            i = fs1.Read(buffer1, 0, Convert.ToInt32(fs1.Length))
            i = fs2.Read(buffer2, 0, Convert.ToInt32(fs2.Length))

            ' Now, first convert byte arrays into MemoryStreams and then concatenate those streams
            Using pdfStream As New MemoryStream()
                Using fileStream1 As New MemoryStream(buffer1)
                    Using fileStream2 As New MemoryStream(buffer2)
                        ' Create instance of PdfFileEditor class to concatenate streams
                        Dim pdfEditor As New PdfFileEditor()
                        ' Concatenate both input MemoryStreams and save to putput MemoryStream
                        pdfEditor.Concatenate(fileStream1, fileStream2, pdfStream)
                        ' Convert MemoryStream back to byte array
                        Dim data As Byte() = pdfStream.ToArray()
                        ' Create a FileStream to save the output PDF file
                        Dim output As New FileStream(dataDir & Convert.ToString("merged_out_.pdf"), FileMode.Create, FileAccess.Write)
                        ' Write byte array contents in the output file stream
                        output.Write(data, 0, data.Length)
                        ' Close output file
                        output.Close()
                    End Using
                End Using
            End Using
            ' Close input files
            fs1.Close()
            fs2.Close()
            ' ExEnd:ConcatenateMultiplePDFUsingMemoryStream                      
        End Sub
    End Class
End Namespace
