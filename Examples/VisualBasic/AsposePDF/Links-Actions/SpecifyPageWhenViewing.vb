Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.LinksActions
    Public Class SpecifyPageWhenViewing
        Public Shared Sub Run()
            ' ExStart:SpecifyPageWhenViewing
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()

            ' Load the PDF file
            Dim doc As New Document(dataDir & Convert.ToString("SpecifyPageWhenViewing.pdf"))
            ' Get the instance of second page of document
            Dim page2 As Page = doc.Pages(2)
            ' Create the variable to set the zoom factor of target page
            Dim zoom As Double = 1
            ' Create GoToAction instance
            Dim action As New GoToAction(doc.Pages(2))
            ' Go to 2 page
            action.Destination = New XYZExplicitDestination(page2, 0, page2.Rect.Height, zoom)
            ' Set the document open action
            doc.OpenAction = action
            ' Save updated document
            doc.Save(dataDir & Convert.ToString("goto2page_out_.pdf"))
            ' ExEnd:SpecifyPageWhenViewing                        
        End Sub
    End Class
End Namespace
