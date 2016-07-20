Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class TeXToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:TeXToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
                ' Instantiate Latex Load option object
                Dim Latexoptions As New LatexLoadOptions()
                ' Create Document object
                Dim doc As New Document(dataDir & Convert.ToString("samplefile.tex"), Latexoptions)
                ' Save the output in PDF file
                ' ExEnd:TeXToPDF
                doc.Save(dataDir & Convert.ToString("TeXToPDF_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
