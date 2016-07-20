Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.DocumentConversion
    Public Class XMLToPDF
        Public Shared Sub Run()
            ' ExStart:XMLToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Instantiate Document object
            Dim doc As New Document()
            ' Bind source XML file
            doc.BindXml(dataDir & Convert.ToString("log.xml"))
            ' Get reference of page object from XML
            Dim page As Page = DirectCast(doc.GetObjectById("mainSection"), Page)
            ' Get reference of first TextSegment with ID boldHtml
            Dim segment As TextSegment = DirectCast(doc.GetObjectById("boldHtml"), TextSegment)
            ' Get reference of second TextSegment with ID strongHtml
            segment = DirectCast(doc.GetObjectById("strongHtml"), TextSegment)
            ' Save resultant PDF file
            doc.Save(dataDir & Convert.ToString("XMLToPDF_out_.pdf"))
            ' ExEnd:XMLToPDF
        End Sub
    End Class
End Namespace
