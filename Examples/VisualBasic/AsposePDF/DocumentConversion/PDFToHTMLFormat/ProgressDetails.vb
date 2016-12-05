Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class ProgressDetails
        Public Shared Sub Run()
            Try
                ' ExStart:ProgressDetails
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
                Dim licenseFile As String = ""
                ' E.g F:\_Sources\Aspose_5\trunk\testdata\License\Aspose.Total.lic
                Dim license As New License()
                license.SetLicense(licenseFile)
                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
                Dim saveOptions As New HtmlSaveOptions()
                ' SaveOptions.CustomProgressHandler = new HtmlSaveOptions.ConversionProgessEventHandler(ShowProgressOnConsole);
                saveOptions.SplitIntoPages = False
                doc.Save(dataDir & Convert.ToString("ProgressDetails_out_.html"), saveOptions)
                ' ExEnd:ProgressDetails
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:ProgressDetailsHelper
        Public Shared Sub ShowProgressOnConsole(eventInfo As HtmlSaveOptions.ProgressEventHandlerInfo)
            Select Case eventInfo.EventType
                Case HtmlSaveOptions.ProgressEventType.TotalProgress
                    Console.WriteLine([String].Format("{0}  - Conversion progress : {1}% .", DateTime.Now.TimeOfDay, eventInfo.Value.ToString()))
                    Exit Select
                Case HtmlSaveOptions.ProgressEventType.SourcePageAnalized
                    Console.WriteLine([String].Format("{0}  - Source page {1} of {2} analyzed.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case HtmlSaveOptions.ProgressEventType.ResultPageCreated
                    Console.WriteLine([String].Format("{0}  - Result page' S {1} of {2} layout created.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case HtmlSaveOptions.ProgressEventType.ResultPageSaved
                    Console.WriteLine([String].Format("{0}  - Result page {1} of {2} exported.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()))
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub
        ' ExEnd:ProgressDetailsHelper
    End Class
End Namespace