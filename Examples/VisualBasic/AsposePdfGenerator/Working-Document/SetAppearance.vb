Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.WorkingDocuments
    Public Class SetAppearance
        Public Shared Sub Run()
            ' ExStart:SetAppearance
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate Pdf instance
            Dim pdf1 As New AP.Generator.Pdf()

            ' Set OpenType property of Pdf instance to any pre-defined value
            pdf1.OpenType = AP.Generator.OpenType.Thumbnails

            dataDir = dataDir & Convert.ToString("SetAppearance_out_.pdf")
            pdf1.Save(dataDir)
            ' ExEnd:SetAppearance
            Console.WriteLine(Convert.ToString(vbLf & "Appearance setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace