Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class EPUBToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:EPUBToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

                ' Instantiate LoadOption object using EPUB load option
                Dim epubload As New EpubLoadOptions()

                ' Create Document object
                Dim pdf As New Document(dataDir & Convert.ToString("EPUBToPDF.epub"), epubload)

                ' Save the resultant PDF document
                pdf.Save(dataDir & Convert.ToString("EPUBToPDF_out_.pdf"))
                ' ExEnd:EPUBToPDF
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace