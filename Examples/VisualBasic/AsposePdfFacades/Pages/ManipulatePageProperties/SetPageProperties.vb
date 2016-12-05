Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ManipulatePageProperties
    Public Class SetPageProperties
        Public Shared Sub Run()
            ' ExStart:SetPageProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Open document
            Dim pageEditor As New PdfPageEditor()
            pageEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Set page properties
            ' Move origin from (0,0)
            pageEditor.MovePosition(100, 100)
            ' Set page rotations
            Dim pageRotations As New Hashtable()
            pageRotations.Add(1, 90)
            pageRotations.Add(2, 180)
            pageRotations.Add(3, 270)
            ' PageEditor.PageRotations = pageRotations;
            ' Set zoom where 1.0f = 100% zoom
            pageEditor.Zoom = 2.0F
            ' Save updated PDF file
            pageEditor.Save(dataDir & Convert.ToString("SetPageProperties_out_.pdf"))
            ' ExEnd:SetPageProperties
        End Sub
    End Class
End Namespace
