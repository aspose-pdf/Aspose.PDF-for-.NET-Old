Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class AddListItem
        Public Shared Sub Run()
            ' ExStart:AddListItem
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & "AddListItem.pdf")
            ' Add list field in PDF file
            form.AddField(FieldType.ListBox, "listbox", 1, 300, 200, 350, _
                225)
            ' Add list items
            form.AddListItem("listbox", "Item 1")
            form.AddListItem("listbox", "Item 2")
            ' Add multiple list items once
            Dim listItems As String() = {"Item 3", "Item 4", "Item 5"}
            form.AddListItem("listbox", listItems)
            ' Save updated file
            form.Save(dataDir & "AddListItem_out_.pdf")
            ' ExEnd:AddListItem
        End Sub
    End Class
End Namespace
