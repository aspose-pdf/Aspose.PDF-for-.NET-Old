Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Generator

Namespace AsposePdfGenerator.Conversion
    Public Class SVGToPDF
        Public Shared Sub Run()
            ' ExStart:SVGToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()

            ' Instantiate Pdf object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Bind the source SVG file
            pdf.BindSvg(dataDir & Convert.ToString("SVGToPDF.svg"))
            ' Save the resultant PDF document
            pdf.Save(dataDir & Convert.ToString("SVGToPDF_out_.pdf"))
            ' ExEnd:SVGToPDF
        End Sub
    End Class
End Namespace