Imports System.IO
Imports Aspose_Pdf = Aspose.Pdf
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class ConvertFromRGBToGrayscale
        Public Shared Sub Run()
            ' ExStart:ConvertFromRGBToGrayscale 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Load source PDF file
            Using document As New Document(dataDir & Convert.ToString("input.pdf"))
                Dim strategy As New Aspose_Pdf.RgbToDeviceGrayConversionStrategy()
                For idxPage As Integer = 1 To document.Pages.Count
                    ' Get instance of particular page inside PDF
                    Dim page As Page = document.Pages(idxPage)
                    ' Convert the RGB colorspace image to GrayScale colorspace
                    strategy.Convert(page)
                Next
                ' Save resultant file
                document.Save(dataDir & Convert.ToString("Test-gray_out_.pdf"))
            End Using
            ' ExEnd:ConvertFromRGBToGrayscale             
        End Sub
    End Class
End Namespace
