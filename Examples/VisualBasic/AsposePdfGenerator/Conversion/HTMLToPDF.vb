Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Generator

Namespace AsposePdfGenerator.Conversion
    Public Class HTMLToPDF
        Public Shared Sub Run()
            ' ExStart:HTMLToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()

            ' Instantiate an object PDF class
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            ' Add the section to PDF document sections collection
            Dim section As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Read the contents of HTML file into StreamReader object
            Dim r As StreamReader = File.OpenText(dataDir & Convert.ToString("resultant.html"))

            ' Create text paragraphs containing HTML text
            Dim text2 As New Aspose.Pdf.Generator.Text(section, r.ReadToEnd())

            ' Enable the property to display HTML contents within their own formatting
            text2.IsHtmlTagSupported = True

            ' ExStart:OverwriteFontNames
            text2.IfHtmlTagSupportedOverwriteHtmlFontNames = True
            text2.IfHtmlTagSupportedOverwriteHtmlFontSizes = True
            ' ExEnd:OverwriteFontNames            

            ' Add the text paragraphs containing HTML text to the section
            section.Paragraphs.Add(text2)

            ' Specify the URL which serves as images database
            pdf.HtmlInfo.ImgUrl = dataDir

            ' ExStart:SpecialCharacters
            ' Following properties are added from Aspose.Pdf for .NET 8.4.0
            pdf.HtmlInfo.BadHtmlHandlingStrategy = BadHtmlHandlingStrategy.TreatAsPlainText
            pdf.HtmlInfo.ShowUnknownHtmlTagsAsText = True
            ' ExEnd:SpecialCharacters

            ' Save the Pdf document
            pdf.Save(dataDir & Convert.ToString("HTML2pdf_out_.pdf"))
            ' ExEnd:HTMLToPDF
        End Sub
    End Class
End Namespace