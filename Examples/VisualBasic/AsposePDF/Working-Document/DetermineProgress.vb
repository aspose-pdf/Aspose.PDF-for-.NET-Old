Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class DetermineProgress
        Public Shared Sub Run()
            ' ExStart:DetermineProgress
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddTOC.pdf"))
            Dim saveOptions As New DocSaveOptions()
            saveOptions.CustomProgressHandler = New UnifiedSaveOptions.ConversionProgressEventHandler(AddressOf ShowProgressOnConsole)

            dataDir = dataDir & Convert.ToString("DetermineProgress_out_.pdf")
            pdfDocument.Save(dataDir, saveOptions)
            Console.ReadLine()
            ' ExEnd:DetermineProgress
        End Sub
        ' ExStart:ShowProgressOnConsole
        Public Shared Sub ShowProgressOnConsole(eventInfo As DocSaveOptions.ProgressEventHandlerInfo)
            Select Case eventInfo.EventType
                Case DocSaveOptions.ProgressEventType.TotalProgress
                    Console.WriteLine([String].Format("{0}  - Conversion progress : {1}% .", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString()))
                    Exit Select
                Case DocSaveOptions.ProgressEventType.SourcePageAnalized
                    Console.WriteLine([String].Format("{0}  - Source page {1} of {2} analyzed.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case DocSaveOptions.ProgressEventType.ResultPageCreated
                    Console.WriteLine([String].Format("{0}  - Result page's {1} of {2} layout created.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case DocSaveOptions.ProgressEventType.ResultPageSaved
                    Console.WriteLine([String].Format("{0}  - Result page {1} of {2} exported.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case Else
                    Exit Select
            End Select

        End Sub
        ' ExEnd:ShowProgressOnConsole
    End Class
End Namespace
