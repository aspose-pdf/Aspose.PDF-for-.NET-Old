Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Text
    Public Class EmbedFont
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
            ' ExStart:EmbedFont
            ' Create a text object in a section
            Dim t1 As New AP.Generator.Text(sec1, "Arial Bold MT")

            ' Set the font name of a segment in the text object
            t1.Segments(0).TextInfo.FontName = "Arial-BoldMT"

            ' Set the PFM file for the text segment
            t1.Segments(0).TextInfo.FontPfmFile = "_AB_____.PFM"

            ' Set the font encoding file for the text segment
            t1.Segments(0).TextInfo.FontEncodingFile = "CP1250.txt"

            ' Set the font encoding name of the text segment
            t1.Segments(0).TextInfo.FontEncoding = "cp1250"

            ' Set the font outline file for the text segment
            t1.Segments(0).TextInfo.FontOutlineFile = "_AB_____.PFB"

            ' Set IsFontEmbedded to true
            t1.Segments(0).TextInfo.IsFontEmbedded = True
            ' ExEnd:EmbedFont
            dataDir = dataDir & Convert.ToString("EmbedFont_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)

        End Sub
        Public Shared Sub TrueTypeBoldFont()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
            ' ExStart:TrueTypeBoldFont
            ' Create a text object in the section
            Dim t1 As New AP.Generator.Text(sec1, "Courier New Bold font")

            ' Set font name of a specific text segment to courier new
            t1.Segments(0).TextInfo.FontName = "Courier New"

            ' Set the font to bold
            t1.Segments(0).TextInfo.IsTrueTypeFontBold = True
            ' ExEnd:TrueTypeBoldFont
            dataDir = dataDir & Convert.ToString("TrueTypeBoldFont_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)
        End Sub
        Public Shared Sub TrueTypeFont()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
            ' ExStart:TrueTypeFont
            ' Create a text object in the section
            Dim t1 As New AP.Generator.Text(sec1, "Courier New Bold font")

            ' Set font name of a specific text segment to courier new
            t1.Segments(0).TextInfo.FontName = "Courier New"

            ' ExEnd:TrueTypeFont
            dataDir = dataDir & Convert.ToString("TrueTypeFont_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)
        End Sub
        Public Shared Sub Unicode()
            ' ExStart:Unicode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf As New AP.Generator.Pdf()
            ' Set the property to make your application run faster. It will help load the Truetype font faster
            pdf.IsTruetypeFontMapCached = True
            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf.Sections.Add()

            ' To assign a unicode character by it's coding
            Dim t1 As New AP.Generator.Text("&H25A0")
            ' Specify the font face name for first segment in text object
            t1.Segments(0).TextInfo.FontName = "Times New Roman"
            ' Specify that first segment in text is UniCode
            t1.Segments(0).TextInfo.IsUnicode = True
            ' Add text to paragraphs collection of section object
            sec1.Paragraphs.Add(t1)
            ' Save the PDF document
            pdf.Save(dataDir & Convert.ToString("Unicode_out_.pdf"))
            ' ExEnd:Unicode
        End Sub
    End Class
End Namespace