Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ManipulatePageProperties
    Public Class GetPageProperties
        Public Shared Sub Run()
            ' ExStart:GetPageProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Open document
            Dim pageEditor As New PdfPageEditor()
            pageEditor.BindPdf(dataDir & Convert.ToString("pageproperties.pdf"))

            ' Get page properties
            Console.WriteLine(pageEditor.GetPageRotation(1))
            Console.WriteLine(pageEditor.GetPages())
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "trim"))
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "art"))
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "bleed"))
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "crop"))
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "media"))
            ' ExEnd:GetPageProperties
        End Sub
    End Class
End Namespace
