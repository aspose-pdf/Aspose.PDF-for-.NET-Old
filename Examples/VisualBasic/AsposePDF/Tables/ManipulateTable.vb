Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Tables
    Public Class ManipulateTable
        Public Shared Sub Run()
            Try
                ' ExStart:ManipulateTable
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

                ' load existing PDF file
                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Create TableAbsorber object to find tables
                Dim absorber As New TableAbsorber()

                ' Visit first page with absorber
                absorber.Visit(pdfDocument.Pages(1))

                ' Get access to first table on page, their first cell and text fragments in it
                Dim fragment As TextFragment = absorber.TableList(0).RowList(0).CellList(0).TextFragments(1)

                ' Change text of the first text fragment in the cell
                fragment.Text = "hi world"
                dataDir = dataDir & Convert.ToString("ManipulateTable_out_.pdf")
                pdfDocument.Save(dataDir)
                ' ExEnd:ManipulateTable
                Console.WriteLine(Convert.ToString(vbLf & "Table manipulated successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
