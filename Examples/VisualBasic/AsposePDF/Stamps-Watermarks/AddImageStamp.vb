Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class AddImageStamp
        Public Shared Sub Run()
            ' ExStart:AddImageStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddImageStamp.pdf"))

            ' Create image stamp
            Dim imageStamp As New ImageStamp(dataDir & Convert.ToString("aspose-logo.jpg"))
            imageStamp.Background = True
            imageStamp.XIndent = 100
            imageStamp.YIndent = 100
            imageStamp.Height = 300
            imageStamp.Width = 300
            imageStamp.Rotate = Rotation.on270
            imageStamp.Opacity = 0.5
            ' Add stamp to particular page
            pdfDocument.Pages(1).AddStamp(imageStamp)

            dataDir = dataDir & Convert.ToString("AddImageStamp_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:AddImageStamp
            Console.WriteLine(Convert.ToString(vbLf & "Image stamp added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

