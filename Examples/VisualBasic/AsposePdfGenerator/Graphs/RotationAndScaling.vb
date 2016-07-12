Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Graphs
    Public Class RotationAndScaling
        Public Shared Sub Run()
            ' ExStart:RotationAndScaling
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Graphs()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create 1st graph in the section with width=100 and height=400
            Dim graph1 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)

            ' Add 1st graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph1)

            ' Create a rectangle shape with specified coordinates
            Dim rect1 As New Aspose.Pdf.Generator.Rectangle(graph1, 85, 100, 100, 50)

            ' Add the rectangle into the shapes collection of the 1st graph
            graph1.Shapes.Add(rect1)

            ' Create 2nd graph in the section with width=100 and height=400
            Dim graph2 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)

            ' Add 2nd graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph2)

            ' Create a rectangle shape with specified coordinates  
            Dim rect2 As New Aspose.Pdf.Generator.Rectangle(graph2, 85, 100, 100, 50)

            ' Add the rectangle into the shapes collection of the 2nd graph
            graph2.Shapes.Add(rect2)

            ' Rotate the 2nd graph to 30 degree using RotationAngle property
            graph2.GraphInfo.RotationAngle = 30

            ' Create 3rd graph in the section with width=100 and height=400                
            Dim graph3 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)

            ' Add 3rd graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph3)

            ' Create a rectangle shape with specified coordinates
            Dim rect3 As New Aspose.Pdf.Generator.Rectangle(graph3, 85, 100, 100, 50)

            ' Add the rectangle into the shapes collection of the 3rd graph
            graph3.Shapes.Add(rect3)

            ' Adjust the horizontal size of the 3rd graph using ScalingRateX property
            graph3.GraphInfo.ScalingRateX = 1.5F

            dataDir = dataDir & Convert.ToString("RotationAndScaling_out_.pdf")

            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:RotationAndScaling         
        End Sub
    End Class
End Namespace