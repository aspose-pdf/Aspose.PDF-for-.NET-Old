Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.WorkingDocuments
    Public Class SetZoomFactor
        Public Shared Sub Run()
            ' ExStart:SetZoomFactor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate Pdf instance
            Dim pdf1 As New AP.Generator.Pdf()

            ' Set the DestinationType property of Pdf instance to any pre-defined value
            pdf1.DestinationType = AP.Generator.DestinationType.FitPage
            dataDir = dataDir & Convert.ToString("ZoomFactor_out_.pdf")
            pdf1.Save(dataDir)
            ' ExStart:SetZoomFactor
            Console.WriteLine(Convert.ToString(vbLf & "Zoom factor setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
