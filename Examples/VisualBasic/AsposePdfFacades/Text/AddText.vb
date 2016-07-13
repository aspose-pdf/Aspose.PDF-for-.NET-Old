Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Text
    Public Class AddText
        Public Shared Sub Run()
            ' ExStart:AddText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()

            ' Open document
            Dim mender As New PdfFileMend()

            ' Create PdfFileMend object to add text
            mender.BindPdf(dataDir & Convert.ToString("AddText.pdf"))

            ' Create formatted text
            Dim text As New FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.AliceBlue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, True, _
                14)

            ' Set whether to use Word Wrap or not and using which mode
            mender.IsWordWrap = True
            mender.WrapMode = WordWrapMode.[Default]

            ' Add text in the PDF file
            mender.AddText(text, 1, 100, 200, 200, 400)

            ' Save changes
            mender.Save(dataDir & Convert.ToString("AddText_out_.pdf"))

            ' Close PdfFileMend object
            mender.Close()
            ' ExEnd:AddText
        End Sub
    End Class
End Namespace