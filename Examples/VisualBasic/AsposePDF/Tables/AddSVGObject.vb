Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Tables
    Public Class AddSVGObject
        Public Shared Sub Run()
            ' ExStart:AddSVGObject
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Instantiate Document object
            Dim doc As New Document()
            ' Create an image instance
            Dim img As New Image()
            ' Set image type as SVG
            img.FileType = ImageFileType.Svg
            ' Path for source file
            img.File = dataDir + "SVGToPDF.svg"
            ' Set width for image instance
            img.FixWidth = 50
            ' Set height for image instance
            img.FixHeight = 50
            ' Create table instance
            Dim table As New Table()
            ' Set width for table cells
            table.ColumnWidths = "100 100"
            ' Create row object and add it to table instance
            Dim row As Row = table.Rows.Add()
            ' Create cell object and add it to row instance
            Dim cell As Cell = row.Cells.Add()
            ' Add textfragment to paragraphs collection of cell object
            cell.Paragraphs.Add(New TextFragment("First cell"))
            ' Add another cell to row object
            cell = row.Cells.Add()
            ' Add SVG image to paragraphs collection of recently added cell instance
            cell.Paragraphs.Add(img)
            ' Create page object and add it to pages collection of document instance
            Dim page As Page = doc.Pages.Add()
            ' Add table to paragraphs collection of page object
            page.Paragraphs.Add(table)

            dataDir = dataDir & Convert.ToString("AddSVGObject_out_.pdf")
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:AddSVGObject
            Console.WriteLine(Convert.ToString(vbLf & "SVG image added successfully inside a table cell." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace