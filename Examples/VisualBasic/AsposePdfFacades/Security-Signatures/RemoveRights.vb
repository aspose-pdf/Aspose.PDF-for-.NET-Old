Imports System.IO
Imports System
Imports System.Drawing.Imaging
Imports System.Drawing
Imports Aspose.Pdf.Facades
Imports System.Collections

Namespace AsposePDFFacades.SecuritySignatures
    Public Class RemoveRights
        Public Shared Sub Run()
            Try
                ' ExStart:RemoveRights               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                Dim input As String = dataDir & Convert.ToString("DigitallySign.pdf")
                Using pdfSign As New PdfFileSignature()
                    pdfSign.BindPdf(input)
                    If pdfSign.ContainsUsageRights() Then
                        pdfSign.RemoveUsageRights()
                    End If

                    pdfSign.Document.Save(dataDir & Convert.ToString("RemoveRights_out_.pdf"))
                    ' ExEnd:RemoveRights
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
