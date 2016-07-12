Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Imports Aspose.Pdf.Facades
Namespace AsposePDF.Text
    Public Class SearchTextAndAddHyperlink
        Public Shared Sub Run()
            ' ExStart:SearchTextAndAddHyperlink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Create absorber object to find all instances of the input search phrase
            Dim absorber As New TextFragmentAbsorber("\d{4}-\d{4}")
            ' Enable regular expression search
            absorber.TextSearchOptions = New TextSearchOptions(True)
            ' Open document
            Dim editor As New PdfContentEditor()
            ' Bind source PDF file
            editor.BindPdf(dataDir & Convert.ToString("SearchRegularExpressionPage.pdf"))
            ' Accept the absorber for the page
            editor.Document.Pages(1).Accept(absorber)

            Dim dashArray As Integer() = {}
            Dim LEArray As [String]() = {}
            Dim blue As System.Drawing.Color = System.Drawing.Color.Blue

            ' Loop through the fragments
            For Each textFragment As TextFragment In absorber.TextFragments
                textFragment.TextState.ForegroundColor = Color.Blue
                Dim rect As New System.Drawing.Rectangle(CInt(textFragment.Rectangle.LLX), CInt(Math.Round(textFragment.Rectangle.LLY)), CInt(Math.Round(textFragment.Rectangle.Width + 2)), CInt(Math.Round(textFragment.Rectangle.Height + 1)))
                Dim actionName As [Enum]() = New [Enum](1) {PredefinedAction.Document_AttachFile, PredefinedAction.Document_ExtractPages}
                editor.CreateWebLink(rect, "http://www.aspose.com", 1, blue, actionName)
                editor.CreateLine(rect, "", CSng(textFragment.Rectangle.LLX) + 1, CSng(textFragment.Rectangle.LLY) - 1, CSng(textFragment.Rectangle.URX), CSng(textFragment.Rectangle.LLY) - 1, _
                    1, 1, blue, "S", dashArray, LEArray)
            Next

            dataDir = dataDir & Convert.ToString("SearchTextAndAddHyperlink_out_.pdf")
            editor.Save(dataDir)
            editor.Close()
            ' ExEnd:SearchTextAndAddHyperlink
            Console.WriteLine(Convert.ToString(vbLf & "Text replaced and hyperlink added successfully based on a regular expression." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace