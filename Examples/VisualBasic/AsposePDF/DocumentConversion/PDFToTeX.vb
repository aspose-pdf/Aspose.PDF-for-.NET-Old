Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToTeX
        Public Shared Sub Run()
            ' ExStart:PDFToTeX
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Create Document object
            Dim doc As New Document(dataDir & Convert.ToString("PDFToTeX.pdf"))

            ' Instantiate LaTex save option            
            Dim saveOptions As New LaTeXSaveOptions()

            ' Specify the output directory 
            Dim pathToOutputDirectory As String = dataDir

            ' Set the output directory path for save option object
            saveOptions.OutDirectoryPath = pathToOutputDirectory

            ' Save PDF file into LaTex format            
            doc.Save(dataDir & Convert.ToString("PDFToTeX_out_.tex"), saveOptions)
            ' ExEnd:PDFToTeX
        End Sub
    End Class
End Namespace