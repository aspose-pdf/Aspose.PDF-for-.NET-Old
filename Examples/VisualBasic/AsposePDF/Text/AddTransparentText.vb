Imports System.IO
Imports System
Imports APD = Aspose.Pdf.Drawing
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Text
    Public Class AddTransparentText
        Public Shared Sub Run()
            ' ExStart:AddTransparentText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim doc As Document = New Document()
            ' Create page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create Graph object
            Dim canvas As APD.Graph = New APD.Graph(100, 400)
            ' Create rectangle instance with certain dimensions
            Dim rect As APD.Rectangle = New APD.Rectangle(100, 100, 400, 400)
            ' Create color object from Alpha color channel
            rect.GraphInfo.FillColor = AP.Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(12957183)))
            ' Add rectanlge to shapes collection of Graph object
            canvas.Shapes.Add(rect)
            ' Add graph object to paragraphs collection of page object
            page.Paragraphs.Add(canvas)
            ' Set value to not change position for graph object
            canvas.IsChangePosition = False
            ' Create TextFragment instance with sample value
            Dim text As TextFragment = New TextFragment("transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text ")
            ' Create color object from Alpha channel
            Dim color As AP.Color = AP.Color.FromArgb(30, 0, 255, 0)
            ' Set color information for text instance
            text.TextState.ForegroundColor = color
            ' Add text to paragraphs collection of page instance
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("AddTransparentText_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:AddTransparentText            
            Console.WriteLine(Convert.ToString(vbLf & "Transparent text added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
