Imports System.IO
Imports System
Imports System.Collections.Generic
Imports Aspose.Pdf
Imports System.Drawing.Printing
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class PrintPages
        ' ExStart:PrintingJobSettings
        Private Structure PrintingJobSettings
            Public Property ToPage() As Integer
                Get
                    Return m_ToPage
                End Get
                Set(value As Integer)
                    m_ToPage = value
                End Set
            End Property
            Private m_ToPage As Integer
            Public Property FromPage() As Integer
                Get
                    Return m_FromPage
                End Get
                Set(value As Integer)
                    m_FromPage = value
                End Set
            End Property
            Private m_FromPage As Integer
            Public Property OutputFile() As String
                Get
                    Return m_OutputFile
                End Get
                Set(value As String)
                    m_OutputFile = value
                End Set
            End Property
            Private m_OutputFile As String
            Public Property Mode() As System.Drawing.Printing.Duplex
                Get
                    Return m_Mode
                End Get
                Set(value As System.Drawing.Printing.Duplex)
                    m_Mode = value
                End Set
            End Property
            Private m_Mode As System.Drawing.Printing.Duplex
        End Structure
        ' ExEnd:PrintingJobSettings
        Public Shared Sub Run()
            ' ExStart:PrintPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

            Dim printingJobIndex As Integer = 0
            Dim inPdf As String = dataDir & Convert.ToString("input.pdf")
            Dim output As String = dataDir
            Dim printingJobs As IList(Of PrintingJobSettings) = New List(Of PrintingJobSettings)()

            Dim printingJob1 As New PrintingJobSettings()
            printingJob1.FromPage = 1
            printingJob1.ToPage = 3
            printingJob1.OutputFile = output & Convert.ToString("35925_1_3.xps")
            printingJob1.Mode = Duplex.[Default]

            printingJobs.Add(printingJob1)

            Dim printingJob2 As New PrintingJobSettings()
            printingJob2.FromPage = 4
            printingJob2.ToPage = 6
            printingJob2.OutputFile = output & Convert.ToString("35925_4_6.xps")
            printingJob2.Mode = Duplex.Simplex

            printingJobs.Add(printingJob2)

            Dim printingJob3 As New PrintingJobSettings()
            printingJob3.FromPage = 7
            printingJob3.ToPage = 7
            printingJob3.OutputFile = output & Convert.ToString("35925_7.xps")
            printingJob3.Mode = Duplex.[Default]

            printingJobs.Add(printingJob3)

            Dim viewer As New PdfViewer()

            viewer.BindPdf(inPdf)
            viewer.AutoResize = True
            viewer.AutoRotate = True
            viewer.PrintPageDialog = False

            Dim ps As New PrinterSettings()
            Dim pgs As New PageSettings()

            ps.PrinterName = "Microsoft XPS Document Writer"
            ps.PrintFileName = Path.GetFullPath(printingJobs(printingJobIndex).OutputFile)
            ps.PrintToFile = True
            ps.FromPage = printingJobs(printingJobIndex).FromPage
            ps.ToPage = printingJobs(printingJobIndex).ToPage
            ps.Duplex = printingJobs(printingJobIndex).Mode
            ps.PrintRange = PrintRange.SomePages

            pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)
            ps.DefaultPageSettings.PaperSize = pgs.PaperSize
            pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            ' AddHandler viewer.EndPrint, AddressOf (args)
            Dim printEventHandler As System.Drawing.Printing.PrintEventHandler = Sub(sender As Object, args As System.Drawing.Printing.PrintEventArgs)
                                                                                     If (++printingJobIndex < printingJobs.Count) Then
                                                                                         ps.PrintFileName = Path.GetFullPath(printingJobs(printingJobIndex).OutputFile)
                                                                                         ps.FromPage = printingJobs(printingJobIndex).FromPage
                                                                                         ps.ToPage = printingJobs(printingJobIndex).ToPage
                                                                                         ps.Duplex = printingJobs(printingJobIndex).Mode
                                                                                         viewer.PrintDocumentWithSettings(pgs, ps)
                                                                                     End If
                                                                                 End Sub
            AddHandler viewer.EndPrint, printEventHandler


            viewer.PrintDocumentWithSettings(pgs, ps)
            ' ExEnd:PrintPages
        End Sub


    End Class
End Namespace
