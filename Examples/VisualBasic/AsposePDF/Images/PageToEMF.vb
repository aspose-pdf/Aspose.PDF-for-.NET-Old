Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class PageToEMF
        Public Shared Sub Run()
            ' ExStart:PageToEMF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PageToEMF.pdf"))

            Using imageStream As New FileStream(dataDir & Convert.ToString("image_out_.emf"), FileMode.Create)
                ' Create Resolution object
                Dim resolution As New Resolution(300)
                ' Create EMF device with specified attributes
                ' Width, Height, Resolution
                Dim emfDevice As New EmfDevice(500, 700, resolution)

                ' Convert a particular page and save the image to stream
                emfDevice.Process(pdfDocument.Pages(1), imageStream)

                ' Close stream
                imageStream.Close()
            End Using
            ' ExEnd:PageToEMF
            System.Console.WriteLine("PDF page is converted to EMF successfully!")
        End Sub
    End Class
End Namespace

