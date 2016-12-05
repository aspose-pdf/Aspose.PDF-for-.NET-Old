Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Graphs
    Public Class GraphCoordinate
        Public Shared Sub Run()
            ' ExStart:GraphCoordinate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Graphs()

            ' Instantiate a Pdf document object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section to the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a graph object in the section with Width=100 and Height=400
            Dim graph1 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)

            ' Add the graph object to the paragraphs collection of the section
            sec1.Paragraphs.Add(graph1)

            ' Create an array containing the (X,Y) values of 4 control points
            ' Required to position a curve
            Dim posArr As Single() = New Single() {0, 0, 200, 80, 300, 40, _
                350, 90}

            ' Create a curve in the graph with the coordinates given as an array to
            ' The constructor of curve class
            Dim curve1 As New Aspose.Pdf.Generator.Curve(graph1, posArr)

            ' Add the curve shape into the shapes collection of the graph
            graph1.Shapes.Add(curve1)

            dataDir = dataDir & Convert.ToString("GraphCoordinate_out_.pdf")

            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:GraphCoordinate         
        End Sub
    End Class
End Namespace
