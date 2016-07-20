Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.UtilityFeatures
    Public Class SpecifyListItem
        Public Shared Sub Run()
            ' ExStart:SpecifyListItem
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Add four headings in the section
            Dim Level As Integer = 1
            While Level <> 5
                Dim heading2 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, Level)
                Dim segment2 As New Aspose.Pdf.Generator.Segment(heading2)
                heading2.Segments.Add(segment2)
                heading2.IsAutoSequence = True
                segment2.Content = "this is heading of level "
                segment2.Content += Level.ToString()

                ' Add the heading into Table Of Contents. 
                heading2.IsInList = True
                sec1.Paragraphs.Add(heading2)
                Level += 1
            End While

            ' Create a graph and add a curve shape to its shapes collection
            Dim graph1 As New Aspose.Pdf.Generator.Graph(sec1, 100, 400)
            sec1.Paragraphs.Add(graph1)
            Dim posArr As Single() = New Single() {0, 0, 200, 80, 300, 40, _
                350, 90}
            Dim curve1 As New Aspose.Pdf.Generator.Curve(graph1, posArr)
            graph1.Shapes.Add(curve1)

            ' Add the Graph to the List of Figures
            graph1.IsInList = True

            dataDir = dataDir & Convert.ToString("SpecifyListItem_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:SpecifyListItem           
        End Sub

    End Class
End Namespace
