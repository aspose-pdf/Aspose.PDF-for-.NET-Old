Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports APD = Aspose.Pdf.Drawing

Namespace AsposePDF.Graphs
    Public Class CreateRectangleWithAlphaColor
        Public Shared Sub Run()
            ' ExStart:CreateRectangleWithAlphaColor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Graphs()

            ' Instantiate Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create Graph instance
            Dim canvas As New APD.Graph(100, 400)
            ' Create rectangle object with specific dimensions
            Dim rect As New APD.Rectangle(100, 100, 200, 100)
            ' Set graph fill color from System.Drawing.Color structure from a 32-bit ARGB value
            rect.GraphInfo.FillColor = Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(12957183)))
            ' Add rectangle object to shapes collection of Graph instance
            canvas.Shapes.Add(rect)

            ' Create second rectangle object
            Dim rect1 As New APD.Rectangle(200, 150, 200, 100)
            rect1.GraphInfo.FillColor = Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(16118015)))
            canvas.Shapes.Add(rect1)
            ' Add graph instance to paragraph collection of page object
            page.Paragraphs.Add(canvas)

            dataDir = dataDir & Convert.ToString("CreateRectangleWithAlphaColor_out_.pdf")
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:CreateRectangleWithAlphaColor
            Console.WriteLine(Convert.ToString(vbLf & "Rectangle object created successfully with alpha color." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
