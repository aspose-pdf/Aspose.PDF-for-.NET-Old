Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF
    Public Class CGMToPDF
        Public Shared Sub Run()
            ' ExStart:CGMToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Instantiate LoadOption object using CGMLoadOption
            Dim cgmload As New CgmLoadOptions()
            ' Instantiate Document object
            Dim doc As New Document(dataDir & Convert.ToString("CGMToPDF.CGM"), cgmload)
            ' Save the resultant PDF document
            doc.Save(dataDir & Convert.ToString("TECHDRAW_out_.pdf"))
            ' ExEnd:CGMToPDF
        End Sub
    End Class
End Namespace