Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports System

Namespace AsposePdfGenerator.Text
    Public Class SetVerticalAlignment
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a new text paragraph with an initial text segment "Aspose"
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "Aspose")

            ' Add the text paragraph to the section
            sec1.Paragraphs.Add(text1)

            ' Create a new text segment into the text paragraph
            Dim seg2 As Aspose.Pdf.Generator.Segment = text1.Segments.Add("TM")

            ' Set the vertical alignment of text segment "seg2" to Topline by setting
            ' IsBaseline property  ot seg2.TextInfo to true
            seg2.TextInfo.IsBaseline = False
            ' Set the font size information for the segment
            seg2.TextInfo.FontSize = 5

            ' Save the Pdf
            pdf1.Save(dataDir & "SetVerticalAlignment_out_.pdf")

        End Sub
    End Class
End Namespace