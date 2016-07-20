Imports System.IO
Imports System
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class GetZoomFactor
        Public Shared Sub Run()
            ' ExStart:GetZoomFactor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Instantiate new Document object
            Dim doc As New Document(dataDir & Convert.ToString("Zoomed_pdf.pdf"))

            ' Create GoToAction object
            Dim action As GoToAction = TryCast(doc.OpenAction, GoToAction)

            ' Get the Zoom factor of PDF file
            System.Console.WriteLine(TryCast(action.Destination, XYZExplicitDestination).Zoom)
            ' Document zoom value;
            ' ExEnd:GetZoomFactor
        End Sub
    End Class
End Namespace