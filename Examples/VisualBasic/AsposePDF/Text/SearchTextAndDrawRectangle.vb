Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Imports Aspose.Pdf.Facades

Namespace AsposePDF.Text
    Public Class SearchTextAndDrawRectangle
        Public Shared Sub Run()
            ' ExStart:SearchTextAndDrawRectangle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("SearchAndGetTextFromAll.pdf"))

            ' Create TextAbsorber object to find all the phrases matching the regular expression

            Dim textAbsorber As New TextFragmentAbsorber("[\S]+")

            Dim textSearchOptions As New TextSearchOptions(True)

            textAbsorber.TextSearchOptions = textSearchOptions

            document.Pages.Accept(textAbsorber)

            Dim editor = New PdfContentEditor(document)

            For Each textFragment As TextFragment In textAbsorber.TextFragments


                For Each textSegment As TextSegment In textFragment.Segments



                    DrawBox(editor, textFragment.Page.Number, textSegment, System.Drawing.Color.Red)

                Next
            Next
            dataDir = dataDir & Convert.ToString("SearchTextAndDrawRectangle_out_.pdf")
            document.Save(dataDir)
            ' ExEnd:SearchTextAndDrawRectangle
            Console.WriteLine(Convert.ToString(vbLf & "Rectangle drawn successfully on searched text." & vbLf & "File saved at ") & dataDir)
        End Sub
        ' ExStart:DrawBox
        Private Shared Sub DrawBox(ByVal editor As PdfContentEditor, ByVal page As Integer, ByVal segment As TextSegment, ByVal color As System.Drawing.Color)

            Dim lineInfo = New LineInfo()

            lineInfo.Visibility = True

            lineInfo.LineColor = color

            editor.CreatePolygon(lineInfo, page, New System.Drawing.Rectangle(0, 0, 0, 0), Nothing)

        End Sub

        ' ExEnd:DrawBox
    End Class
End Namespace
