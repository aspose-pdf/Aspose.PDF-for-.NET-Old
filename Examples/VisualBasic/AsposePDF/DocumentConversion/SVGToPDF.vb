Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class SVGToPDF
        Public Shared Sub Run()
            ' ExStart:SVGToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Instantiate LoadOption object using SVG load option
            Dim loadopt As LoadOptions = New SvgLoadOptions()

            ' Create Document object
            Dim doc As New Document(dataDir & Convert.ToString("SVGToPDF.svg"), loadopt)

            ' Save the resultant PDF document
            doc.Save(dataDir & Convert.ToString("SVGToPDF_out_.pdf"))
            ' ExEnd:SVGToPDF
        End Sub
    End Class
End Namespace