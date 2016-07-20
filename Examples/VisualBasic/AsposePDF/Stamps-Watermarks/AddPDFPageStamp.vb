Imports System.IO
Imports Microsoft.VisualBasic
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class AddPDFPageStamp
        Public Shared Sub Run()
            ' ExStart:PDFPageStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFPageStamp.pdf"))


            ' Create page stamp
            Dim pageStamp As New PdfPageStamp(pdfDocument.Pages(1))
            pageStamp.Background = True
            pageStamp.XIndent = 100
            pageStamp.YIndent = 100
            pageStamp.Rotate = Rotation.on180

            'add stamp to particular page
            pdfDocument.Pages(1).AddStamp(pageStamp)

            dataDir = dataDir & Convert.ToString("PDFPageStamp_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:PDFPageStamp
            Console.WriteLine(Convert.ToString(vbLf & "Pdf page stamp added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
