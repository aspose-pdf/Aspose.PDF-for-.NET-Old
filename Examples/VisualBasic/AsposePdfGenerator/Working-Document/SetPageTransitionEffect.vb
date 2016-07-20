Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.WorkingDocuments
    Public Class SetPageTransitionEffect
        Public Shared Sub Run()
            ' ExStart:SetPageTransitionEffect
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate Pdf instance
            Dim pdf1 As New AP.Generator.Pdf()

            ' You may set OpenType poperty to full screen
            pdf1.OpenType = AP.Generator.OpenType.FullScreen

            ' Set PageTransitionType poperty of Pdf instance to a pre-defined desired value
            pdf1.PageTransitionType = AP.Generator.PageTransitionType.Dissolve

            dataDir = dataDir & Convert.ToString("PageTransition_out_.pdf")
            pdf1.Save(dataDir)
            ' ExEnd:SetPageTransitionEffect
            Console.WriteLine(Convert.ToString(vbLf & "Page transition effect setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
