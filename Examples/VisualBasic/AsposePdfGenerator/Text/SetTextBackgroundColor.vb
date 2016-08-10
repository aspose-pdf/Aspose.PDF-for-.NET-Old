Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class SetTextBackgroundColor
        Public Shared Sub Run()
            ' ExStart:SetTextBackgroundColor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "Hello Aspose.Pdf")

            ' Set the BackgroundColor of the text paragraph to Red
            text1.TextInfo.BackgroundColor = New Aspose.Pdf.Generator.Color("Red")

            ' Add the text paragraph to the section
            sec1.Paragraphs.Add(text1)

            ' Save the Pdf
            pdf1.Save(dataDir & "SetTextBackgroundColor_out_.pdf")
            ' ExEnd:SetTextBackgroundColor

        End Sub
    End Class
End Namespace