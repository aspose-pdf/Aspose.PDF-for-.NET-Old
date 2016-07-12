Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PCLToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:PCLToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

                ' Instantiate LoadOption object using PCL load option
                Dim loadopt As LoadOptions = New PclLoadOptions()

                ' Create Document object
                Dim doc As New Document(dataDir & Convert.ToString("hidetext.pcl"), loadopt)

                ' Save the resultant PDF document
                ' ExEnd:PCLToPDF
                doc.Save(dataDir & Convert.ToString("PCLToPDF_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
