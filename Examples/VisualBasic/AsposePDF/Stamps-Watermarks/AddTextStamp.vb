Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.StampsWatermarks
    Public Class AddTextStamp
        Public Shared Sub Run()
            ' ExStart:AddTextStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddTextStamp.pdf"))

            ' Create text stamp
            Dim textStamp As New TextStamp("Sample Stamp")
            ' Set whether stamp is background
            textStamp.Background = True
            ' Set origin
            textStamp.XIndent = 100
            textStamp.YIndent = 100
            ' Rotate stamp
            textStamp.Rotate = Rotation.on90
            ' Set text properties
            textStamp.TextState.Font = FontRepository.FindFont("Arial")
            textStamp.TextState.FontSize = 14.0F
            textStamp.TextState.FontStyle = FontStyles.Bold
            textStamp.TextState.FontStyle = FontStyles.Italic
            textStamp.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Aqua)
            ' Add stamp to particular page
            pdfDocument.Pages(1).AddStamp(textStamp)

            dataDir = dataDir & Convert.ToString("AddTextStamp_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:AddTextStamp
            Console.WriteLine(Convert.ToString(vbLf & "Text stamp added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace