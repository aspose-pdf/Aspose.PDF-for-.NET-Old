Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Headings
    Public Class ApplyNumberStyle
        Public Shared Sub Run()
            ' ExStart:ApplyNumberStyle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Headings()

            Dim pdfDoc As New Document()
            pdfDoc.PageInfo.Width = 612.0
            pdfDoc.PageInfo.Height = 792.0
            pdfDoc.PageInfo.Margin = New MarginInfo()
            pdfDoc.PageInfo.Margin.Left = 72
            pdfDoc.PageInfo.Margin.Right = 72
            pdfDoc.PageInfo.Margin.Top = 72
            pdfDoc.PageInfo.Margin.Bottom = 72

            Dim pdfPage As Page = pdfDoc.Pages.Add()
            pdfPage.PageInfo.Width = 612.0
            pdfPage.PageInfo.Height = 792.0
            pdfPage.PageInfo.Margin = New MarginInfo()
            pdfPage.PageInfo.Margin.Left = 72
            pdfPage.PageInfo.Margin.Right = 72
            pdfPage.PageInfo.Margin.Top = 72
            pdfPage.PageInfo.Margin.Bottom = 72

            Dim floatBox As New FloatingBox()
            floatBox.Margin = pdfPage.PageInfo.Margin

            pdfPage.Paragraphs.Add(floatBox)

            Dim textFragment As New TextFragment()
            Dim segment As New TextSegment()

            Dim heading As New Heading(1)
            heading.IsInList = True
            heading.StartNumber = 1
            heading.Text = "List 1"
            heading.Style = NumberingStyle.NumeralsRomanLowercase
            heading.IsAutoSequence = True

            floatBox.Paragraphs.Add(heading)

            Dim heading2 As New Heading(1)
            heading2.IsInList = True
            heading2.StartNumber = 13
            heading2.Text = "List 2"
            heading2.Style = NumberingStyle.NumeralsRomanLowercase
            heading2.IsAutoSequence = True

            floatBox.Paragraphs.Add(heading2)

            Dim heading3 As New Heading(2)
            heading3.IsInList = True
            heading3.StartNumber = 1
            heading3.Text = "the value, as of the effective date of the plan, of property to be distributed under the plan onaccount of each allowed"
            heading3.Style = NumberingStyle.LettersLowercase
            heading3.IsAutoSequence = True

            floatBox.Paragraphs.Add(heading3)
            dataDir = dataDir & Convert.ToString("ApplyNumberStyle_out_.pdf")
            pdfDoc.Save(dataDir)
            ' ExEnd:ApplyNumberStyle
            Console.WriteLine(Convert.ToString(vbLf & "Number style applied successfully in headings." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
