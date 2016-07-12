Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Text
Imports System.Xml

Namespace AsposePdfGenerator.Text
    Public Class SuperSubscript
        Public Shared Sub Run()
            Try
                ' ExStart:SuperSubscript
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

                ' Instantiate a pdf document
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Create a section in the pdf document
                Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

                ' Create a string variable with html text containing Sub & Sup tags
                Dim string1 As String = "<FONT face=""Times New Roman"" size=18>HARBIN<sup>[1234]</sup> : An unexpected stoppage of water<sub>[abcd]</sub>  supply sparked <sup> rumours of a contaminated river</sup> and led to a run on city <sub>supermarkets storing bottled water</sub> yesterday.</FONT>"

                ' Create text paragraph containing HTML text
                Dim text1 As New Aspose.Pdf.Generator.Text(string1)
                text1.IsHtmlTagSupported = True

                ' Add the text paragraph containing HTML text to the section
                sec1.Paragraphs.Add(text1)

                ' Save the document
                ' ExEnd:SuperSubscript
                pdf1.Save(dataDir & Convert.ToString("SuperSubscript_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace