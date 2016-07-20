Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDF.Images
    Public Class CGMImageToPDF
        Public Shared Sub Run()
            ' ExStart:CGMImageToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            Dim inputFile As String = dataDir & Convert.ToString("corvette.cgm")
            dataDir = dataDir & Convert.ToString("CGMImageToPDF_out_.pdf")
            ' Save CGM into PDF format
            PdfProducer.Produce(inputFile, ImportFormat.Cgm, dataDir)
            ' ExEnd:CGMImageToPDF
            Console.WriteLine(Convert.ToString(vbLf & "CGM file converted to pdf successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
