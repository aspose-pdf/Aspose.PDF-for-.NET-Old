Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Text
    Public Class SymbolFont
        Public Shared Sub Run()
            ' ExStart:SymbolFont
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph inheriting text format settings from the section
            Dim text1 As New AP.Generator.Text(sec1)

            ' Add the text paragraph to the section
            sec1.Paragraphs.Add(text1)

            ' Create 1st text segment
            Dim s1 As New AP.Generator.Segment("183")

            ' Set the font name to the TextInfo.FontName property of segment
            s1.TextInfo.FontName = "Symbol"

            ' Add 1st text segment to the text paragraph
            text1.Segments.Add(s1)

            ' Create 2nd text segment
            Dim s2 As New AP.Generator.Segment(" the first item")

            ' Add 2nd text segment to the text paragraph
            text1.Segments.Add(s2)

            dataDir = dataDir & Convert.ToString("SymbolFont_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)
            ' ExEnd:SymbolFont
        End Sub
    End Class
End Namespace
