Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class ConvertAllPagesToEMF
        Public Shared Sub Run()
            ' ExStart:ConvertAllPagesToEMF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ConvertAllPagesToEMF.pdf"))

            For pageCount As Integer = 1 To pdfDocument.Pages.Count
                Using imageStream As New FileStream("image" & pageCount & "_out" & ".emf", FileMode.Create)
                    ' Create Resolution object
                    Dim resolution As New Resolution(300)
                    ' Create EMF device with specified attributes
                    ' Width, Height, Resolution
                    Dim emfDevice As New EmfDevice(500, 700, resolution)

                    ' Convert a particular page and save the image to stream
                    emfDevice.Process(pdfDocument.Pages(pageCount), imageStream)

                    ' Close stream
                    imageStream.Close()

                End Using
            Next pageCount
            ' ExEnd:ConvertAllPagesToEMF
            System.Console.WriteLine("PDF pages are converted to EMF successfully!")
        End Sub
    End Class
End Namespace
