Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace AsposePDF.Images
    Public Class LargeCGMImageToPDF
        Public Shared Sub Run()
            ' ExStart:LargeCGMImageToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            Dim inputFile As String = dataDir & Convert.ToString("corvette.cgm")
            dataDir = dataDir & Convert.ToString("LargeCGMImageToPDF_out_.pdf")

            ' Create an instance of CgmImportOptions
            Dim options As New CgmImportOptions()

            ' Specify the dimentions for page size import 
            options.PageSize = New SizeF(1000, 1000)

            ' Save CGM into PDF format
            PdfProducer.Produce(inputFile, ImportFormat.Cgm, dataDir)
            ' ExEnd:LargeCGMImageToPDF
            Console.WriteLine(Convert.ToString(vbLf & "Large CGM file converted to pdf successfully." & vbLf & "File saved at ") & dataDir)

        End Sub

    End Class
End Namespace

