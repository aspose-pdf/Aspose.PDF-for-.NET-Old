Imports System.IO
Imports System
Imports Aspose.Pdf.Drawing
Imports APW = Aspose.Pdf.Drawing
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Graphs
    Public Class AddDrawing
        Public Shared Sub Run()
            ' ExStart:AddDrawing
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            Dim alpha As Integer = 10
            Dim green As Integer = 0
            Dim red As Integer = 100
            Dim blue As Integer = 0
            ' Create Color object using Alpha RGB 
            Dim alphaColor As Color = Color.FromArgb(alpha, red, green, blue)
            ' provide alpha channel
            ' Instantiate Document object
            Dim document As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = document.Pages.Add()
            ' Create Graph object with certain dimensions
            Dim graph As New Graph(300, 400)
            ' Set border for Drawing object
            graph.Border = (New BorderInfo(BorderSide.All, Color.Black))
            ' Add graph object to paragraphs collection of Page instance
            page.Paragraphs.Add(graph)
            ' Create Rectangle object with certain dimensions
            Dim rectangle As New APW.Rectangle(0, 0, 100, 50)
            ' Create graphInfo object for Rectangle instance
            Dim graphInfo As GraphInfo = rectangle.GraphInfo
            ' Set color information for GraphInfo instance
            graphInfo.Color = (Color.Red)
            ' Set fill color for GraphInfo
            graphInfo.FillColor = (alphaColor)
            ' Add rectangle shape to shapes collection of graph object
            graph.Shapes.Add(rectangle)
            dataDir = dataDir & Convert.ToString("AddDrawing_out_.pdf")
            ' Save PDF file
            document.Save(dataDir)
            ' ExEnd:AddDrawing
            Console.WriteLine(Convert.ToString(vbLf & "Drawing added successfully with transparent color." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace