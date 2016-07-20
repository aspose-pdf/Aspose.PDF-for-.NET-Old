Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class GetSVGDimensions
        Public Shared Sub Run()
            ' ExStart:GetSVGDimensions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim loadopt = New SvgLoadOptions()
            loadopt.AdjustPageSize = True
            Dim svgDoc = New Document(dataDir & Convert.ToString("GetSVGDimensions.svg"), loadopt)
            svgDoc.Pages(1).PageInfo.Margin.Top = 0
            svgDoc.Pages(1).PageInfo.Margin.Left = 0
            svgDoc.Pages(1).PageInfo.Margin.Bottom = 0
            svgDoc.Pages(1).PageInfo.Margin.Right = 0
            svgDoc.Save(dataDir & Convert.ToString("GetSVGDimensions_out_.pdf"))
            ' ExEnd:GetSVGDimensions
        End Sub
    End Class
End Namespace