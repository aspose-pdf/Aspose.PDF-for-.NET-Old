Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Tables
    Public Class SetBorder
        Public Shared Sub Run()
            ' ExStart:SetBorder
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Instantiate Document object
            Dim doc As New Document()
            ' Add page to PDF document
            Dim page As Page = doc.Pages.Add()
            ' Create BorderInfo object
            Dim border As New BorderInfo(BorderSide.All)
            ' Specify that Top border will be double
            border.Top.IsDoubled = True
            ' Specify that bottom border will be double
            border.Bottom.IsDoubled = True
            ' Instantiate Table object
            Dim table As New Table()
            ' Specify Columns width information
            table.ColumnWidths = "100"
            ' Create Row object
            Dim row As Row = table.Rows.Add()
            ' Add a Table cell to cells collection of row
            Dim cell As Cell = row.Cells.Add("some text")
            ' Set the border for cell object (double border)
            cell.Border = border
            ' Add table to paragraphs collection of Page
            page.Paragraphs.Add(table)
            dataDir = dataDir & Convert.ToString("TableBorderTest_out_.pdf")
            ' Save the PDF document
            doc.Save(dataDir)
            ' ExEnd:SetBorder
            Console.WriteLine(Convert.ToString(vbLf & "Border setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
