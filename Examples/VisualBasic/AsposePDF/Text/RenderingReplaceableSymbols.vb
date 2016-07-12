Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Text
    Public Class RenderingReplaceableSymbols
        Public Shared Sub Run()
            ' ExStart:RenderingReplaceableSymbols
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim pdfApplicationDoc As New Document()
            Dim applicationFirstPage As Page = DirectCast(pdfApplicationDoc.Pages.Add(), Page)

            ' Initialize new TextFragment with text containing required newline markers
            Dim textFragment As New TextFragment("Applicant Name: " + Environment.NewLine + " Joe Smoe")

            ' Set text fragment properties if necessary
            textFragment.TextState.FontSize = 12
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman")
            textFragment.TextState.BackgroundColor = Color.LightGray
            textFragment.TextState.ForegroundColor = Color.Red

            ' Create TextParagraph object
            Dim par As New TextParagraph()

            ' Add new TextFragment to paragraph
            par.AppendLine(textFragment)

            ' Set paragraph position
            par.Position = New Position(100, 600)

            ' Create TextBuilder object
            Dim textBuilder As New TextBuilder(applicationFirstPage)
            ' Add the TextParagraph using TextBuilder
            textBuilder.AppendParagraph(par)

            dataDir = dataDir & Convert.ToString("RenderingReplaceableSymbols_out_.pdf")
            pdfApplicationDoc.Save(dataDir)
            ' ExEnd:RenderingReplaceableSymbols            
            Console.WriteLine(Convert.ToString(vbLf & "Replaceable symbols render successfully duing pdf creation." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace