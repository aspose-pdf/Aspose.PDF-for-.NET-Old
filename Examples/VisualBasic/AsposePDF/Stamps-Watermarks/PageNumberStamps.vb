Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.StampsWatermarks
    Public Class PageNumberStamps
        Public Shared Sub Run()
            ' ExStart:PageNumberStamps
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PageNumberStamp.pdf"))

            ' Create page number stamp
            Dim pageNumberStamp As New PageNumberStamp()
            ' Whether the stamp is background
            pageNumberStamp.Background = False
            pageNumberStamp.Format = "Page # of " + pdfDocument.Pages.Count.ToString()
            pageNumberStamp.BottomMargin = 10
            pageNumberStamp.HorizontalAlignment = HorizontalAlignment.Center
            pageNumberStamp.StartingNumber = 1
            ' Set text properties
            pageNumberStamp.TextState.Font = FontRepository.FindFont("Arial")
            pageNumberStamp.TextState.FontSize = 14.0F
            pageNumberStamp.TextState.FontStyle = FontStyles.Bold
            pageNumberStamp.TextState.FontStyle = FontStyles.Italic
            pageNumberStamp.TextState.ForegroundColor = Color.Aqua

            ' Add stamp to particular page
            pdfDocument.Pages(1).AddStamp(pageNumberStamp)

            dataDir = dataDir & Convert.ToString("PageNumberStamp_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:PageNumberStamps
            Console.WriteLine(Convert.ToString(vbLf & "Page number stamp added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
