Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Text
Imports System.Xml

Namespace AsposePdfGenerator.Text
    Public Class AddFootnotes
        Public Shared Sub Run()
            Try
                ' ExStart:AddFootnotes
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

                ' Instantiate a pdf document
                Dim pdf As New Aspose.Pdf.Generator.Pdf()

                ' Create Section
                Dim sec As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

                ' Create Text Paragraph
                Dim text As New Aspose.Pdf.Generator.Text()

                ' Create Segment
                Dim segment As New Aspose.Pdf.Generator.Segment("This is the First Segment")

                ' Create FootNote and Assign FootNote property of Segment to its object
                segment.FootNote = New Aspose.Pdf.Generator.FootNote("Footnotes for First Segment")

                ' Add Segment in Text Paragraph
                text.Segments.Add(segment)

                ' Add Text in Section
                sec.Paragraphs.Add(text)

                ' Save the document
                ' ExEnd:AddFootnotes
                pdf.Save(dataDir & Convert.ToString("AddFootnotes_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
