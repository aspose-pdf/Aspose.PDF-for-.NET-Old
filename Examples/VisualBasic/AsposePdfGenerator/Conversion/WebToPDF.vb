Imports System.IO
Imports System
Imports System.Net
Imports Aspose.Pdf
Imports System.Text

Namespace AsposePdfGenerator.Conversion
    Public Class WebToPDF
        Public Shared Sub Run()
            ' ExStart:WebToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()

            ' The address of the web URL which you need to convert into PDF format
            Dim WebUrl As String = "http://en.wikipedia.org/wiki/Main_Page"
            ' Create a Web Request object to connect to remote URL
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(WebUrl), HttpWebRequest)
            ' Set the Web Request timeout
            request.Timeout = 10000
            ' 10 secs
            ' Retrieve request info headers
            Dim localWebResponse As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            ' Windows default Code Page  (Include System.Text namespace in project)
            Dim encoding__1 As Encoding = Encoding.GetEncoding(1252)
            ' Read the contents of into StreamReader object
            Dim localResponseStream As New StreamReader(localWebResponse.GetResponseStream(), encoding__1)

            ' Instantiate an object PDF class
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            ' Add the section to PDF document sections collection
            Dim section As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Create text paragraphs containing HTML text
            Dim text2 As New Aspose.Pdf.Generator.Text(section, localResponseStream.ReadToEnd())

            ' Enable the property to display HTML contents within their own formatting
            text2.IsHtmlTagSupported = True

            ' Add the text object containing HTML contents to PD Sections
            section.Paragraphs.Add(text2)

            ' Specify the URL which serves as images database
            ' Pdf.HtmlInfo.ImgUrl = "http://en.wikipedia.org/";
            ' Save the pdf document            
            pdf.Save(dataDir & Convert.ToString("WebToPDF_out_.pdf"))
            localWebResponse.Close()
            localResponseStream.Close()
            ' ExEnd:WebToPDF
        End Sub
    End Class
End Namespace