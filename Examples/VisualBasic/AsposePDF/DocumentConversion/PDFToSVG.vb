Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToSVG
        Public Shared Sub Run()
            ' ExStart:PDFToSVG
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Instantiate an object of SvgSaveOptions
            Dim saveOptions As New SvgSaveOptions()
            ' Do not compress SVG image to Zip archive
            saveOptions.CompressOutputToZipArchive = False
            ' Save the output in SVG files
            doc.Save(dataDir & Convert.ToString("PDFToSVG_out_.svg"), saveOptions)
            ' ExEnd:PDFToSVG
        End Sub
    End Class
End Namespace
