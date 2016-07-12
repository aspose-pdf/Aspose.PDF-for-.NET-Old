Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Text
Imports System.Xml

Namespace AsposePdfGenerator.Text
    Public Class HyperlinkTags
        Public Shared Sub Run()
            Try
                ' ExStart:HyperlinkTags
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

                ' Instantiate a pdf document
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Create a section in the pdf document
                Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

                ' Create a string variable with text containing hyperlink tag
                Dim string1 As String = "<a href=""http://www.aspose.com/"">This is a test</a>"

                ' Create text paragraph containing HTML hyperlink tag
                Dim text1 As New Aspose.Pdf.Generator.Text(string1)
                text1.IsHtmlTagSupported = True

                ' Add the text paragraph containing HTML text to the section
                sec1.Paragraphs.Add(text1)

                ' Save the document
                ' ExEnd:HyperlinkTags
                pdf1.Save(dataDir & Convert.ToString("HyperlinkTags_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
