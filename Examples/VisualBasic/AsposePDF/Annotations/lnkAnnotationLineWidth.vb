Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections

Namespace AsposePDF.Annotations
    Public Class lnkAnnotationLineWidth
        Public Shared Sub Run()
            ' ExStart:lnkAnnotationLineWidth
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            Dim doc As New Document()
            doc.Pages.Add()
            Dim inkList As New ArrayList()
            Dim lineInfo As New LineInfo()
            lineInfo.VerticeCoordinate = New Single() {55, 55, 70, 70, 70, 90, _
                150, 60}
            lineInfo.Visibility = True
            lineInfo.LineColor = System.Drawing.Color.Red
            lineInfo.LineWidth = 2
            Dim length As Integer = Convert.ToInt32( lineInfo.VerticeCoordinate.Length / 2)
            Dim gesture As Point() = New Point(length - 1) {}
            For i As Integer = 0 To length - 1
                gesture(i) = New Point(lineInfo.VerticeCoordinate(2 * i), lineInfo.VerticeCoordinate(2 * i + 1))
            Next

            inkList.Add(gesture)
            Dim a1 As New InkAnnotation(doc.Pages(1), New Rectangle(10, 10, 200, 200), inkList)
            a1.Subject = "Test"
            a1.Title = "Title"
            a1.Color = Color.FromRgb(System.Drawing.Color.Green)
            Dim border As New Border(a1)
            border.Width = 3
            border.Effect = BorderEffect.Cloudy
            border.Dash = New Dash(1, 1)
            border.Style = BorderStyle.Solid
            doc.Pages(1).Annotations.Add(a1)

            dataDir = dataDir & Convert.ToString("lnkAnnotationLineWidth_out_.pdf")
            ' Save output file
            doc.Save(dataDir)
            ' ExEnd:lnkAnnotationLineWidth
            Console.WriteLine(Convert.ToString(vbLf & "lnk annotation line width setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
