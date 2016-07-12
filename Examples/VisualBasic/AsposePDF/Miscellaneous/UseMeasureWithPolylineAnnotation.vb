Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Miscellaneous
    Public Class UseMeasureWithPolylineAnnotation
        Public Shared Sub Run()
            ' ExStart:UseMeasureWithPolylineAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Miscellaneous()

            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            Dim vertices As Point() = New Point() {New Point(100, 600), New Point(500, 600), New Point(500, 500), New Point(400, 300), New Point(100, 500), New Point(100, 600)}
            Dim rect As New Rectangle(100, 500, 500, 600)

            'Area or perimeter line
            Dim area As New PolylineAnnotation(doc.Pages(1), rect, vertices)
            area.Color = Color.Red

            'Line endings can be set for perimeter line.
            area.StartingStyle = LineEnding.OpenArrow
            area.EndingStyle = LineEnding.OpenArrow
            area.Measure = New Measure(area)
            area.Measure.DistanceFormat = New Measure.NumberFormatList(area.Measure)
            area.Measure.DistanceFormat.Add(New Measure.NumberFormat(area.Measure))
            area.Measure.DistanceFormat(1).UnitLabel = "mm"
            doc.Pages(1).Annotations.Add(area)
            doc.Save(dataDir & Convert.ToString("UseMeasureWithPolylineAnnotation_out_.pdf"))
            ' ExEnd:UseMeasureWithPolylineAnnotation
        End Sub
    End Class
End Namespace