Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class CustomTabStops
        Public Shared Sub Run()
            ' ExStart:CustomTabStops
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim _pdfdocument As New Document()
            Dim page As Page = _pdfdocument.Pages.Add()

            Dim ts As New TabStops()
            Dim ts1 As TabStop = ts.Add(100)
            ts1.AlignmentType = TabAlignmentType.Right
            ts1.LeaderType = TabLeaderType.Solid
            Dim ts2 As TabStop = ts.Add(200)
            ts2.AlignmentType = TabAlignmentType.Center
            ts2.LeaderType = TabLeaderType.Dash
            Dim ts3 As TabStop = ts.Add(300)
            ts3.AlignmentType = TabAlignmentType.Left
            ts3.LeaderType = TabLeaderType.Dot

            Dim header As New TextFragment("This is a example of forming table with TAB stops", ts)
            Dim text0 As New TextFragment("#$TABHead1 #$TABHead2 #$TABHead3", ts)

            Dim text1 As New TextFragment("#$TABdata11 #$TABdata12 #$TABdata13", ts)
            Dim text2 As New TextFragment("#$TABdata21 ", ts)
            text2.Segments.Add(New TextSegment("#$TAB"))
            text2.Segments.Add(New TextSegment("data22 "))
            text2.Segments.Add(New TextSegment("#$TAB"))
            text2.Segments.Add(New TextSegment("data23"))

            page.Paragraphs.Add(header)
            page.Paragraphs.Add(text0)
            page.Paragraphs.Add(text1)
            page.Paragraphs.Add(text2)

            dataDir = dataDir & Convert.ToString("CustomTabStops_out_.pdf")
            _pdfdocument.Save(dataDir)
            ' ExEnd:CustomTabStops            
            Console.WriteLine(Convert.ToString(vbLf & "Custom tab stops setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
