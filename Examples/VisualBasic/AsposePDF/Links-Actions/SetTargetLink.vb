Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations

Namespace AsposePDF.LinksActions
    Public Class SetTargetLink
        Public Shared Sub Run()
            Try
                ' ExStart:SetTargetLink
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim document As New Document(dataDir & Convert.ToString("UpdateLinks.pdf"))

                Dim linkAnnot As LinkAnnotation = DirectCast(document.Pages(1).Annotations(1), LinkAnnotation)

                Dim goToR As GoToRemoteAction = DirectCast(linkAnnot.Action, GoToRemoteAction)
                ' Next line update destination, do not update file
                goToR.Destination = New XYZExplicitDestination(2, 0, 0, 1.5)
                ' Next line update file
                goToR.File = New FileSpecification(dataDir & Convert.ToString("input.pdf"))

                dataDir = dataDir & Convert.ToString("SetTargetLink_out_.pdf")
                ' Save the document with updated link
                document.Save(dataDir)
                ' ExEnd:SetTargetLink
                Console.WriteLine(Convert.ToString(vbLf & "Target link setup successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
