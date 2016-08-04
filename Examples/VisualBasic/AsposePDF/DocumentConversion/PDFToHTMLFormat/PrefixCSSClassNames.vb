Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class PrefixCSSClassNames
        Public Shared Sub Run()
            Try
                ' ExStart:PrefixCSSClassNames
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))
                Dim outHtmlFile As String = dataDir & Convert.ToString("PrefixCSSClassNames_out_.html")
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.CssClassNamesPrefix = ".gDV__ .stl_"
                pdfDocument.Save(outHtmlFile, saveOptions)
                ' ExEnd:PrefixCSSClassNames
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace