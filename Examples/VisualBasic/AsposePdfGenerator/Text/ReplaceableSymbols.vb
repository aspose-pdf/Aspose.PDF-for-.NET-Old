Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class ReplaceableSymbols
        Public Shared Sub Run()
            ' ExStart:ReplaceableSymbols
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Create a HeaderFooter object for the section
            Dim hf As New AP.Generator.HeaderFooter(sec1)

            ' Set the HeaderFooter object to odd and even footers
            sec1.OddFooter = InlineAssignHelper(sec1.EvenFooter, hf)

            ' Add a text paragraph containing current page number of total number of pages
            hf.Paragraphs.Add(New AP.Generator.Text(hf, "page $p of $P"))

            dataDir = dataDir & Convert.ToString("ReplaceableSymbols_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)
            ' ExEnd:ReplaceableSymbols
        End Sub
        Public Shared Sub SpecifiedParagraph()
            ' ExStart:SpecifiedParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
            ' Create a sample text paragraph
            Dim text1 As New AP.Generator.Text("page 1")
            ' Specify the ID for text paragraph
            text1.ID = "page1"
            ' Add text to paragraphs collection of section
            sec1.Paragraphs.Add(text1)
            ' Add a new text paragraph with symbol to print page number information for text paragraph with ID page4
            sec1.Paragraphs.Add(New AP.Generator.Text("The last page is #$REFPAGE(page4)."))

            ' Create a new Text paragraph with sample text
            Dim text2 As New AP.Generator.Text("page 2")
            ' Specify the ID for text paragraph
            text2.ID = "page2"
            ' Specify that text2 is first paragraph of section
            text2.IsFirstParagraph = True
            ' Add text paragraph to paragraphs collection of section object
            sec1.Paragraphs.Add(text2)

            Dim text3 As New AP.Generator.Text("page 3")
            text3.ID = "page3"
            text3.IsFirstParagraph = True
            sec1.Paragraphs.Add(text3)

            Dim sec2 As AP.Generator.Section = pdf1.Sections.Add()
            Dim text4 As New AP.Generator.Text("page 4")
            text4.ID = "page4"
            sec2.Paragraphs.Add(text4)

            pdf1.Save(dataDir & Convert.ToString("test_out_.pdf"))

            ' ExEnd:SpecifiedParagraph
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function


    End Class
End Namespace