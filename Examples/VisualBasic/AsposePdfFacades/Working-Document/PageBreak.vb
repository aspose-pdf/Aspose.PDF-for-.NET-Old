Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.WorkingDocument
    Public Class PageBreak
        Public Shared Sub Run()
            Try
                ' ExStart:PageBreak
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()
                ' Instantiate Document instance
                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Instantiate blank Document instance
                Dim dest As New Document()
                ' Create PdfFileEditor object
                Dim fileEditor As New PdfFileEditor()
                fileEditor.AddPageBreak(doc, dest, New PdfFileEditor.PageBreak() {New PdfFileEditor.PageBreak(1, 450)})
                ' Save resultant file
                ' ExEnd:PageBreak  
                dest.Save(dataDir & Convert.ToString("PageBreak_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
        Public Shared Sub PageBreakWithDestPath()
            Try
                ' ExStart:PageBreakWithDestPath
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()

                ' Create PdfFileEditor object
                Dim fileEditor As New PdfFileEditor()

                ' ExEnd:PageBreakWithDestPath  
                fileEditor.AddPageBreak(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("PageBreakWithDestPath_out_.pdf"), New PdfFileEditor.PageBreak() {New PdfFileEditor.PageBreak(1, 450)})
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
        Public Shared Sub PageBreakWithStream()
            Try
                ' ExStart:PageBreakWithStream
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()

                Dim src As Stream = New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open, FileAccess.Read)
                Dim dest As Stream = New FileStream(dataDir & Convert.ToString("PageBreakWithStream_out_.pdf"), FileMode.Create, FileAccess.ReadWrite)
                Dim fileEditor As New PdfFileEditor()
                fileEditor.AddPageBreak(src, dest, New PdfFileEditor.PageBreak() {New PdfFileEditor.PageBreak(1, 450)})
                dest.Close()
                ' ExEnd:PageBreakWithStream  
                src.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class

End Namespace
