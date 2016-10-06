Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class XMLToPdf
        Public Shared Sub Run()
            ' ExStart:XMLToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            Dim src As Stream = New FileStream(dataDir & Convert.ToString("log.xml"), FileMode.Open, FileAccess.Read)
            Dim dest As Stream = New FileStream(dataDir & Convert.ToString("XMLToPdf_out_.pdf"), FileMode.Create, FileAccess.ReadWrite)
            FormDataConverter.ConvertXmlToFdf(src, dest)
            dest.Close()
            src.Close()
            ' ExEnd:XMLToPdf                      
        End Sub
    End Class
End Namespace
