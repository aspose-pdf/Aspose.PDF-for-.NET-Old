Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Graphs
    Public Class GraphFormat
        Public Shared Sub Run()
            ' ExStart:GraphFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Graphs()

            ' Instantiate Pdf document by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a graph in the section with Width=100 and Height=400
            Dim graph1 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)

            ' Add the graph object to paragraphs collection of the section
            sec1.Paragraphs.Add(graph1)

            ' Create a circle shape in the graph with X=200, Y=50 and Radius=30
            Dim circle1 As New Aspose.Pdf.Generator.Circle(graph1, 200, 50, 30)

            ' Add the circle in the shapes collection of the graph
            graph1.Shapes.Add(circle1)

            ' Set fill color of the circle using GraphInfo property of circle object
            circle1.GraphInfo.FillColor = New Aspose.Pdf.Generator.Color("Green")

            ' Enable the circle to be filled with the color specified above line
            circle1.GraphInfo.IsFilled = True

            dataDir = dataDir & Convert.ToString("GraphFormat_out_.pdf")

            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:GraphFormat         
        End Sub
    End Class
End Namespace
