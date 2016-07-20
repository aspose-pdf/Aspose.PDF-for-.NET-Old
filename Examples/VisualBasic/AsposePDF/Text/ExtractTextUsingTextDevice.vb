Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Devices
Imports Aspose.Pdf.Text.TextOptions
Imports System.Text

Namespace AsposePDF.Text
    Public Class ExtractTextUsingTextDevice
        Public Shared Sub Run()
            ' ExStart:ExtractTextUsingTextDevice
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))
            Dim builder As New System.Text.StringBuilder()
            ' String to hold extracted text
            Dim extractedText As String = ""

            For Each pdfPage As Page In pdfDocument.Pages
                Using textStream As New MemoryStream()
                    ' Create text device
                    Dim textDevice As New TextDevice()

                    ' Set text extraction options - set text extraction mode (Raw or Pure)
                    Dim textExtOptions As New TextExtractionOptions(TextExtractionOptions.TextFormattingMode.Pure)
                    textDevice.ExtractionOptions = textExtOptions

                    ' Convert a particular page and save text to the stream
                    textDevice.Process(pdfPage, textStream)
                    ' ExStart:SaveTextToStream
                    ' Convert a particular page and save text to the stream
                    textDevice.Process(pdfDocument.Pages(1), textStream)
                    ' ExEnd:SaveTextToStream

                    ' Close memory stream
                    textStream.Close()

                    ' Get text from memory stream
                    extractedText = Encoding.Unicode.GetString(textStream.ToArray())
                End Using
                builder.Append(extractedText)
            Next

            dataDir = dataDir & Convert.ToString("input_Text_Extracted_out_.txt")
            ' Save the extracted text in text file
            File.WriteAllText(dataDir, builder.ToString())
            ' ExEnd:ExtractTextUsingTextDevice            
            Console.WriteLine(Convert.ToString(vbLf & "Text extracted successfully using text device from page of PDF Document." & vbLf & "File saved at ") & dataDir)
        End Sub

    End Class
End Namespace