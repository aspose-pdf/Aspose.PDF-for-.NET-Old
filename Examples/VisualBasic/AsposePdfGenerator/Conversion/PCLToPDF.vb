Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Conversion
    Public Class PCLToPDF
        Public Shared Sub Run()
            ' ExStart:PCLToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()

            ' Instantiate Pdf object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Bind the source PCL file
            pdf.BindPCL(dataDir & Convert.ToString("hidetext.pcl"))
            ' Save the resultant PDF document
            pdf.Save(dataDir & Convert.ToString("PCLToPDF_out_.pdf"))
            ' ExEnd:PCLToPDF
        End Sub
    End Class
End Namespace
