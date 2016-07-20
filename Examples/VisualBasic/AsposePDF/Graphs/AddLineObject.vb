Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Drawing
Imports Aspose.Pdf

Namespace AsposePDF.Graphs
    Public Class AddLineObject
        Public Shared Sub Run()
            ' ExStart:AddLineObject
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create Graph instance
            Dim graph As New Graph(100, 400)
            ' Add graph object to paragraphs collection of page instance
            page.Paragraphs.Add(graph)
            ' Create Rectangle instance
            Dim line As New Line(New Single() {100, 100, 200, 100})
            ' Specify fill color for Graph object
            line.GraphInfo.DashArray = New Integer() {0, 1, 0}
            line.GraphInfo.DashPhase = 1
            ' Add rectangle object to shapes collection of Graph object
            graph.Shapes.Add(line)
            dataDir = dataDir & Convert.ToString("AddLineObject_out_.pdf")
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:AddLineObject
            Console.WriteLine(Convert.ToString(vbLf & "Line object added successfully to pdf." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace