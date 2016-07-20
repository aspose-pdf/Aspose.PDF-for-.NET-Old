Imports System.IO
Imports System
Imports System.Windows.Forms
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class CheckPrintJobStatus
        Public Shared Sub Run()
            Try
                ' ExStart:CheckPrintJobStatus
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

                ' Instantiate PdfViewer object
                Dim viewer As New PdfViewer()

                ' Bind source PDF file
                viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))
                viewer.AutoResize = True

                ' Hide printing dialog
                viewer.PrintPageDialog = False

                ' Create Printer Settings object
                Dim ps As New System.Drawing.Printing.PrinterSettings()
                Dim pgs As New System.Drawing.Printing.PageSettings()
                Dim prtdoc As New System.Drawing.Printing.PrintDocument()

                ' Specify the printer anme
                ps.PrinterName = "Microsoft XPS Document Writer"

                ' Resultant Printout name
                ps.PrintFileName = "ResultantPrintout.xps"

                ' Print the output to file
                ps.PrintToFile = True
                ps.FromPage = 1
                ps.ToPage = 2
                ps.PrintRange = System.Drawing.Printing.PrintRange.SomePages

                ' Specify the page size of printout
                pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)
                ps.DefaultPageSettings.PaperSize = pgs.PaperSize
                pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

                ' Print the document with settings specified above
                viewer.PrintDocumentWithSettings(pgs, ps)

                ' Check the print status
                If viewer.PrintStatus IsNot Nothing Then
                    ' An exception was thrown
                    Dim ex As Exception = TryCast(viewer.PrintStatus, Exception)
                    ' Get exception message
                    If ex IsNot Nothing Then
                    End If
                Else
                    ' No errors were found. Printing job has completed successfully
                    Console.WriteLine("printing completed without any issue..")
                End If
                ' ExEnd:CheckPrintJobStatus
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Public Shared Sub GetSetPrintOwnerName()
            ' ExStart:GetSetPrintOwnerName
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()
            Dim viewer As New PdfViewer()
            ' Bind source PDF file
            viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Specify the name of Print job
            viewer.PrinterJobName = GetCurrentUserCredentials()
            ' ExEnd:GetSetPrintOwnerName
        End Sub
        ' ExStart:GetCurrentUserCredentials
        Private Shared Function GetCurrentUserCredentials() As String
            ' The implementation depends on type of running application (ASP.NET, Windows forms, etc.)
            Dim userCredentials As String = String.Empty
            Return userCredentials
        End Function
        ' ExEnd:GetCurrentUserCredentials
        Public Shared Sub UsingImpersonation()
            ' ExStart:UsingImpersonation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()
            Dim viewer As New PdfViewer()
            viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))
            viewer.PrintPageDialog = False
            ' Do not produce the page number dialog when printing
            Using New Impersonator("OwnerUserName", "SomeDomain", "OwnerUserNamePassword")
                Dim ps As New System.Drawing.Printing.PrinterSettings()
                ps.PrinterName = "Microsoft XPS Document Writer"
                viewer.PrintDocumentWithSettings(ps)
                ' OwnerUserName is a value of Owner column in spooler app
                viewer.Close()
            End Using
            ' ExEnd:UsingImpersonation
        End Sub
    End Class
End Namespace
