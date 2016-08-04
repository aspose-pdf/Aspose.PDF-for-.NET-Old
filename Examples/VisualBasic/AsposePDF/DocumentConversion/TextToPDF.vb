Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.DocumentConversion
    Public Class TextToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:TextToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
                ' Read the source text file
                Dim tr As TextReader = New StreamReader(dataDir & Convert.ToString("log.txt"))

                ' Instantiate a Document object by calling its empty constructor
                Dim doc As New Document()

                ' Add a new page in Pages collection of Document
                Dim page As Page = doc.Pages.Add()

                ' Create an instance of TextFragmet and pass the text from reader object to its constructor as argument
                Dim text As New TextFragment(tr.ReadToEnd())
                ' Text.TextState.Font = FontRepository.FindFont("Arial Unicode MS");

                ' Add a new text paragraph in paragraphs collection and pass the TextFragment object
                page.Paragraphs.Add(text)

                ' Save resultant PDF file
                doc.Save(dataDir & Convert.ToString("TexttoPDF_out_.pdf"))
                ' ExEnd:TextToPDF
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
