Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.LinksActions
    Public Class UpdateLinks
        Public Shared Sub Run()
            Try
                ' ExStart:UpdateLinks
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim doc As New Document(dataDir & Convert.ToString("UpdateLinks.pdf"))
                ' Get the first link annotation from first page of document
                Dim linkAnnot As LinkAnnotation = DirectCast(doc.Pages(1).Annotations(1), LinkAnnotation)
                ' Modification link: change link destination
                Dim goToAction As GoToAction = DirectCast(linkAnnot.Action, GoToAction)
                ' Specify the destination for link object
                ' The first parameter is document object, second is destination page number.
                ' The 5ht argument is zoom factor when displaying the respective page. When using 2, the page will be displayed in 200% zoom
                goToAction.Destination = New XYZExplicitDestination(1, 1, 2, 2)
                dataDir = dataDir & Convert.ToString("PDFLINK_Modified_UpdateLinks_out_.pdf")
                ' Save the document with updated link
                doc.Save(dataDir)
                ' ExEnd:UpdateLinks
                Console.WriteLine(Convert.ToString(vbLf & "Links updated successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace