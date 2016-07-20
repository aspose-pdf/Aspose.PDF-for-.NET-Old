Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Paragraphs
    Public Class SetMargins
        Public Shared Sub Run()
            ' ExStart:SetMargins
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs()

            ' Instantiate Pdf object by calling its empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Add a new section to the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Instantiate a graph object, associate it with a section and pass the height
            ' & width of the graph
            Dim g1 As New AP.Generator.Graph(sec1, 100, 100)

            ' Add a graph object to the paragraphs collection of the section
            sec1.Paragraphs.Add(g1)

            ' Add a circle object to the shapes collection of graph object
            g1.Shapes.Add(New AP.Generator.Circle(g1, 50, 50, 30))

            ' Instantiate another Graph object, associate it with a section and pass the height
            ' & width of the graph
            Dim g2 As New AP.Generator.Graph(sec1, 100, 100)

            ' Set the value of left margin
            g2.Margin.Left = 150

            ' Set the value of top margin and assign a negative value to it
            g2.Margin.Top = -100

            ' Add the paragraph object "g2" to paragraphs collection of the section
            sec1.Paragraphs.Add(g2)

            ' Add a rectangle to the graph object (g2) in its shapes collection
            g2.Shapes.Add(New AP.Generator.Rectangle(g2, 20, 20, 60, 60))

            dataDir = dataDir & Convert.ToString("SetMargins_out_.pdf")
            ' Save the resultant PDF
            pdf1.Save(dataDir)
            ' ExEnd:SetMargins
            Console.WriteLine(Convert.ToString(vbLf & "Paragraph margins setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
