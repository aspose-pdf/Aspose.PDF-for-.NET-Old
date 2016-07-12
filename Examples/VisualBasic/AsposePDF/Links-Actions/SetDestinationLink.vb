Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.LinksActions
    Public Class SetDestinationLink
        Public Shared Sub Run()
            Try
                ' ExStart:SetDestinationLink
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim doc As New Document(dataDir & Convert.ToString("UpdateLinks.pdf"))

                ' Get the first link annotation from first page of document
                Dim linkAnnot As LinkAnnotation = DirectCast(doc.Pages(1).Annotations(1), LinkAnnotation)
                ' Modification link: change link action and set target as web address
                linkAnnot.Action = New GoToURIAction("www.aspose.com")

                dataDir = dataDir & Convert.ToString("SetDestinationLink_out_.pdf")
                ' Save the document with updated link
                doc.Save(dataDir)
                ' ExEnd:SetDestinationLink
                Console.WriteLine(Convert.ToString(vbLf & "Destination link setup successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
