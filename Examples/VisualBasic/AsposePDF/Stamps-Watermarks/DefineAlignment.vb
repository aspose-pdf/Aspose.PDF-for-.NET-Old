Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDF.StampsWatermarks
    Public Class DefineAlignment
        Public Shared Sub Run()
            ' ExStart:DefineAlignment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Instantiate Document object with input file
            Dim doc As New Document(dataDir & Convert.ToString("DefineAlignment.pdf"))
            ' Instantiate FormattedText object with sample string
            Dim text As New FormattedText("This")
            ' Add new text line to FormattedText
            text.AddNewLineText("is sample")
            text.AddNewLineText("Center Aligned")
            text.AddNewLineText("TextStamp")
            text.AddNewLineText("Object")
            ' Create TextStamp object using FormattedText
            Dim stamp As New TextStamp(text)
            ' Specify the Horizontal Alignment of text stamp as Center aligned
            stamp.HorizontalAlignment = HorizontalAlignment.Center
            ' Specify the Vertical Alignment of text stamp as Center aligned
            stamp.VerticalAlignment = VerticalAlignment.Center
            ' Specify the Text Horizontal Alignment of TextStamp as Center aligned
            stamp.TextAlignment = HorizontalAlignment.Center
            ' Set top margin for stamp object
            stamp.TopMargin = 20
            ' Add the stamp object over first page of document
            doc.Pages(1).AddStamp(stamp)

            dataDir = dataDir & Convert.ToString("StampedPDF_out_.pdf")
            ' Save the udpated document
            doc.Save(dataDir)
            ' ExEnd:DefineAlignment            
            Console.WriteLine(Convert.ToString(vbLf & "Alignment defined successfully for text stamp." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
