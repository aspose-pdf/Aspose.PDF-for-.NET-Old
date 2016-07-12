Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.LinksActions
    Public Class RemoveOpenAction
        Public Shared Sub Run()
            ' ExStart:RemoveOpenAction
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("RemoveOpenAction.pdf"))
            ' Remove document open action
            document.OpenAction = Nothing
            dataDir = dataDir & Convert.ToString("RemoveOpenAction_out_.pdf")
            ' Save updated document
            document.Save(dataDir)
            ' ExEnd:RemoveOpenAction
            Console.WriteLine(Convert.ToString(vbLf & "Open action removed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
