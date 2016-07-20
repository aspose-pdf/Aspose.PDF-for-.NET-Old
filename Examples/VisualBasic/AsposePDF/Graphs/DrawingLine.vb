Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports APD = Aspose.Pdf.Drawing

Namespace AsposePDF.Graphs
    Public Class DrawingLine
        Public Shared Sub Run()
            ' ExStart:DrawingLine
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Create Document instance
            Dim pDoc As New Document()
            ' Add page to pages collection of PDF document
            Dim pg As Page = pDoc.Pages.Add()
            ' set page margin on all sides as 0
            pg.PageInfo.Margin.Left = InlineAssignHelper(pg.PageInfo.Margin.Right, InlineAssignHelper(pg.PageInfo.Margin.Bottom, InlineAssignHelper(pg.PageInfo.Margin.Top, 0)))
            ' Create Graph object with Width and Height equal to page dimensions
            Dim graph As New APD.Graph(CSng(pg.PageInfo.Width), CSng(pg.PageInfo.Height))
            ' Create first line object starting from Lower-Left to Top-Right corner of page
            Dim line As New APD.Line(New Single() {CSng(pg.Rect.LLX), 0, CSng(pg.PageInfo.Width), CSng(pg.Rect.URY)})
            ' Add line to shapes collection of Graph object
            graph.Shapes.Add(line)
            ' Draw line from Top-Left corner of page to Bottom-Right corner of page
            Dim line2 As New APD.Line(New Single() {0, CSng(pg.Rect.URY), CSng(pg.PageInfo.Width), CSng(pg.Rect.LLX)})
            ' Add line to shapes collection of Graph object
            graph.Shapes.Add(line2)
            ' Add Graph object to paragraphs collection of page
            pg.Paragraphs.Add(graph)

            dataDir = dataDir & Convert.ToString("DrawingLine_out_.pdf")
            ' Save PDF file
            pDoc.Save(dataDir)
            ' ExEnd:DrawingLine
            Console.WriteLine(Convert.ToString(vbLf & "Line drawn successfully across the page." & vbLf & "File saved at ") & dataDir)
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace
