Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.WorkingDocuments
    Public Class SetZoomFactor
        Public Shared Sub Run()
            ' ExStart:SetZoomFactor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Instantiate new Document object
            Dim doc As New Document(dataDir & Convert.ToString("SetZoomFactor.pdf"))

            Dim action As New GoToAction(New XYZExplicitDestination(1, 0, 0, 0.5))
            doc.OpenAction = action
            dataDir = dataDir & Convert.ToString("Zoomed_pdf_out_.pdf")
            ' Save the document
            doc.Save(dataDir)
            ' ExEnd:SetZoomFactor
            Console.WriteLine(Convert.ToString(vbLf & "Zoom factor setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

