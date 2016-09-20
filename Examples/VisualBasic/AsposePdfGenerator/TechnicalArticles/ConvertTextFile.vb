Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class ConvertTextFile
        Public Shared Sub Run()
            ' ExStart:ConvertTextFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Read the source text file
            Dim tr As System.IO.TextReader = New StreamReader(dataDir & Convert.ToString("test.txt"))

            ' Instantiate Pdf pbject by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a new section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a new text paragraph and pass the text to its constructor as argument
            Dim t2 As New Aspose.Pdf.Generator.Text(tr.ReadToEnd())
            sec1.Paragraphs.Add(t2)

            pdf1.Save(dataDir & Convert.ToString("ConvertTextFile_out_.Pdf"))
            ' ExEnd:ConvertTextFile           

        End Sub
        Public Shared Sub ConvertLargeTextFile()
            ' ExStart:ConvertLargeTextFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate Pdf pbject by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a new section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Specify the location of input text file
            Dim FILE_NAME As [String] = dataDir & Convert.ToString("test.txt")

            If File.Exists(FILE_NAME) Then

                Dim objReader As System.IO.TextReader = New System.IO.StreamReader(FILE_NAME)
                ' Read the file till the end of the file has come
                Do
                    ' Create a new text paragraph & pass text to its constructor as argument
                    Dim t2 As New Aspose.Pdf.Generator.Text(objReader.ReadLine())
                    ' Add the text object to paragraphs collection of section

                    ' Read till the end of file
                    sec1.Paragraphs.Add(t2)
                Loop While objReader.Peek() <> -1

                ' Close the StreamReader object
                objReader.Close()
            Else
                Console.WriteLine("File Does Not Exist")
            End If

            ' Save the PDF file
            pdf1.Save(dataDir & Convert.ToString("ConvertLargeTextFile_out_.pdf"))
            ' ExEnd:ConvertLargeTextFile

        End Sub
    End Class
End Namespace
