Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.DocumentConversion
    Public Class ReplaceMissingFonts
        Public Shared Sub Run()
            ' ExStart:ReplaceMissingFonts
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim originalFont As Aspose.Pdf.Text.Font = Nothing
            Try
                originalFont = FontRepository.FindFont("AgencyFB")
            Catch generatedExceptionName As Exception
                'Font is missing on destination machine
                FontRepository.Substitutions.Add(New SimpleFontSubstitution("AgencyFB", "Arial"))
            End Try
            Dim fileNew = New FileInfo(dataDir & Convert.ToString("newfile_out_.pdf"))
            Dim pdf = New Document(dataDir & Convert.ToString("input.pdf"))
            pdf.Convert(dataDir & Convert.ToString("log.xml"), PdfFormat.PDF_A_1B, ConvertErrorAction.Delete)
            pdf.Save(fileNew.FullName)
            ' ExEnd:ReplaceMissingFonts
        End Sub
    End Class
End Namespace
