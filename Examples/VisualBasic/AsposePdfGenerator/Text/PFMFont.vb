Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class PFMFont
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
            ' ExStart:PFMFont
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
            ' ExEnd:PFMFont
            dataDir = dataDir & Convert.ToString("PFMFont_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)

        End Sub
    End Class
End Namespace