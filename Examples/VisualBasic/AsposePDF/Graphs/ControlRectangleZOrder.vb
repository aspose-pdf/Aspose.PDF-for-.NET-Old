Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Drawing
Imports APW = Aspose.Pdf.Drawing
Imports Aspose.Pdf

Namespace AsposePDF.Graphs
    Public Class ControlRectangleZOrder
        Public Shared Sub Run()
            ' ExStart:ControlRectangleZOrder
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Instantiate Document class object
            Dim doc1 As New Document()
            ''' Add page to pages collection of PDF file
            Dim page1 As Page = doc1.Pages.Add()
            ' Set size of PDF page
            page1.SetPageSize(375, 300)
            ' Set left margin for page object as 0
            page1.PageInfo.Margin.Left = 0
            ' Set top margin of page object as 0
            page1.PageInfo.Margin.Top = 0
            ' Create a new rectangle with Color as Red, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 50, 40, 60, 40, Color.Red, _
                2)
            ' Create a new rectangle with Color as Blue, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 20, 20, 30, 30, Color.Blue, _
                1)
            ' Create a new rectangle with Color as Green, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 40, 40, 60, 30, Color.Green, _
                0)
            dataDir = dataDir & Convert.ToString("ControlRectangleZOrder_out_.pdf")
            ' Save resultant PDF file
            doc1.Save(dataDir)
            ' ExEnd:ControlRectangleZOrder

        End Sub
        ' ExStart:AddRectangle
        Private Shared Sub AddRectangle(page As Page, x As Single, y As Single, width As Single, height As Single, color As Color, _
            zindex As Integer)
            ' Create graph object with dimensions same as specified for Rectangle object
            Dim graph As New Graph(width, height)
            ' Can we change the position of graph instance
            graph.IsChangePosition = False
            ' Set Left coordinate position for Graph instance
            graph.Left = x
            ' Set Top coordinate position for Graph object
            graph.Top = y
            ' Add a rectangle inside the "graph"
            Dim rect As New APW.Rectangle(0, 0, width, height)
            ' Set rectangle fill color
            rect.GraphInfo.FillColor = color
            ' Color of graph object
            rect.GraphInfo.Color = color
            ' Add rectangle to shapes collection of graph instance
            graph.Shapes.Add(rect)
            ' Set Z-Index for rectangle object
            graph.ZIndex = zindex
            ' Add graph to paragraphs collection of page object
            page.Paragraphs.Add(graph)
        End Sub
        ' ExEnd:AddRectangle
    End Class
End Namespace