Imports System.IO
Imports System
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.Miscellaneous
    Public Class UseMeasureWithLineAnnotation
        Public Shared Sub Run()
            ' ExStart:UseMeasureWithLineAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Miscellaneous()

            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            Dim rect As New Rectangle(260, 630, 451, 662)
            Dim line As New LineAnnotation(doc.Pages(1), rect, New Point(266, 657), New Point(446, 656))
            line.Color = Color.Red

            ' Set extension line parameters.
            line.LeaderLine = -15
            line.LeaderLineExtension = 5

            ' Set line endings
            line.StartingStyle = LineEnding.OpenArrow
            line.EndingStyle = LineEnding.OpenArrow

            ' Create Measure element
            line.Measure = New Measure(line)
            line.Measure.DistanceFormat = New Measure.NumberFormatList(line.Measure)
            line.Measure.DistanceFormat.Add(New Measure.NumberFormat(line.Measure))
            line.Measure.DistanceFormat(1).UnitLabel = "mm"
            line.Measure.DistanceFormat(1).FractionSeparator = "."
            line.Measure.DistanceFormat(1).ConvresionFactor = 1

            ' Text of measure line
            line.Contents = "155 mm"
            ' This must be set to show the text.
            line.ShowCaption = True
            line.CaptionPosition = CaptionPosition.Top
            doc.Pages(1).Annotations.Add(line)
            doc.Save(dataDir & Convert.ToString("UseMeasureWithLineAnnotation_out_.pdf"))
            ' ExEnd:UseMeasureWithLineAnnotation
        End Sub
    End Class
End Namespace
