Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Generator
Namespace AsposePdfGenerator.Conversion
    Public Class HTMLToPDFUsingStream
        Public Shared Sub Run()
            ' ExStart:HTMLToPDFUsingStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()
            ' Instantiate Pdf object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Specify the Character encoding for HTML file
            pdf.HtmlInfo.CharSet = "UTF-8"
            pdf.HtmlInfo.CharsetApplyingLevelOfForce = HtmlInfo.CharsetApplyingForceLevel.UseWhenImpossibleDetectFromContent
            ' Load the HTML file to Stream object
            Using htmlAsStream As Stream = System.IO.File.OpenRead(dataDir & Convert.ToString("resultant.html"))
                ' Bind the source HTML
                pdf.BindHTML(htmlAsStream, "")
            End Using
            ' Save the PDF file
            pdf.Save(dataDir & Convert.ToString("HTMLToPDFUsingStream_out_.pdf"))
            ' ExEnd:HTMLToPDFUsingStream
        End Sub
        Public Shared Sub EnforceUseAlways()
            ' ExStart:EnforceUseAlways
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()
            ' Instantiate Pdf object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Specify the Character encoding for HTML file
            pdf.HtmlInfo.CharSet = "UTF-8"
            pdf.HtmlInfo.CharsetApplyingLevelOfForce = HtmlInfo.CharsetApplyingForceLevel.EnforceUseAlways
            ' Load the HTML file to Stream object
            Using htmlAsStream As Stream = System.IO.File.OpenRead(dataDir & Convert.ToString("resultant.html"))
                ' Bind the source HTML
                pdf.BindHTML(htmlAsStream, "")
            End Using
            ' Save the PDF file
            pdf.Save(dataDir & Convert.ToString("EnforceUseAlways_out_.pdf"))
            ' ExEnd:EnforceUseAlways
        End Sub
    End Class
End Namespace