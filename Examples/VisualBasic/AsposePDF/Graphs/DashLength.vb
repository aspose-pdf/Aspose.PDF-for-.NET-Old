Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports APD = Aspose.Pdf.Drawing

Namespace AsposePDF.Graphs
    Public Class DashLength
        Public Shared Sub Run()
            ' ExStart:DashLength
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Instantiate Document instance
            Dim doc As New Document()
            ' Add page to pages collection of Document object
            Dim page As Page = doc.Pages.Add()
            ' Create Drawing object with certain dimensions
            Dim canvas As New APD.Graph(100, 400)
            ' Add drawing object to paragraphs collection of page instance
            page.Paragraphs.Add(canvas)
            ' Create Line object
            Dim line As New APD.Line(New Single() {100, 100, 200, 100})
            ' Set color for Line object
            line.GraphInfo.Color = Color.Red
            ' Specify dash array for line object
            line.GraphInfo.DashArray = New Integer() {0, 1, 0}
            ' Set the dash phase for Line instance
            line.GraphInfo.DashPhase = 1
            ' Add line to shapes collection of drawing object
            canvas.Shapes.Add(line)
            dataDir = dataDir & Convert.ToString("DashLength_out_.pdf")
            ' Save PDF document
            doc.Save(dataDir)
            ' ExEnd:DashLength
            Console.WriteLine(Convert.ToString(vbLf & "Length dashed successfully in black and white." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace