Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class XPSToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:XPSToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

                ' Instantiate LoadOption object using XPS load option
                Dim options As LoadOptions = New XpsLoadOptions()

                ' Create document object 
                Dim document As New Document(dataDir & Convert.ToString("XPSToPDF.xps"), options)

                ' Save the resultant PDF document
                ' ExEnd:XPSToPDF
                document.Save(dataDir & Convert.ToString("XPSToPDF_out_.pdf"))
            Catch ex As Exception

                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace