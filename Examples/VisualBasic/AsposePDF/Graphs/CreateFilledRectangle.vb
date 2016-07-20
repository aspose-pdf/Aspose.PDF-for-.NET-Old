Imports System.IO
Imports Aspose.Pdf
Imports Microsoft.VisualBasic
Imports System
Imports APD = Aspose.Pdf.Drawing

Namespace AsposePDF.Graphs
    Public Class CreateFilledRectangle
        Public Shared Sub Run()
            ' ExStart:CreateFilledRectangle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create Graph instance
            Dim graph As New APD.Graph(100, 400)
            ' Add graph object to paragraphs collection of page instance
            page.Paragraphs.Add(graph)
            ' Create Rectangle instance
            Dim rect As New APD.Rectangle(100, 100, 200, 120)
            ' Specify fill color for Graph object
            rect.GraphInfo.FillColor = Color.Red
            ' Add rectangle object to shapes collection of Graph object
            graph.Shapes.Add(rect)
            dataDir = dataDir & Convert.ToString("CreateFilledRectangle_out_.pdf")
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:CreateFilledRectangle
            Console.WriteLine(Convert.ToString(vbLf & "Filled rectangle object created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace