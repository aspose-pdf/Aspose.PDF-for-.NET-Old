Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class DeleteListItem
        Public Shared Sub Run()
            ' ExStart:DeleteListItem
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("AddListItem.pdf"))
            ' Delete list item
            form.DelListItem("listbox", "Item 2")
            ' Save updated file
            form.Save(dataDir & Convert.ToString("DeleteListItem_out_.pdf"))
            ' ExEnd:DeleteListItem
        End Sub
    End Class
End Namespace
