Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Paragraphs
    Public Class Render
        Public Shared Sub Run()
            ' ExStart:Render
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a section in the Pdf document
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Add a text paragraph in the section
            sec1.Paragraphs.Add(New AP.Generator.Text("page 1"))

            ' Create another text paragraph that has to be rendered
            Dim t2 As New AP.Generator.Text("page2")

            ' Set the IsFirstParagraph property of the text paragraph to true
            ' to render it to a new page
            t2.IsFirstParagraph = True

            ' Add the text paragraph to be rendered to the section
            sec1.Paragraphs.Add(t2)

            dataDir = dataDir & Convert.ToString("RenderParagraph_out_.pdf")
            ' Save the Pdf document
            pdf1.Save(dataDir)
            ' ExEnd:Render   
            Console.WriteLine(Convert.ToString(vbLf & "Paragraph renders successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace