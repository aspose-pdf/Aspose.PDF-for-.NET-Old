Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.StampsWatermarks
    Public Class AddingDifferentHeaders
        Public Shared Sub Run()
            ' ExStart:AddingDifferentHeaders
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open source document
            Dim doc As New Document(dataDir & Convert.ToString("AddingDifferentHeaders.pdf"))

            ' Create three stamps
            Dim stamp1 As New TextStamp("Header 1")
            Dim stamp2 As New TextStamp("Header 2")
            Dim stamp3 As New TextStamp("Header 3")

            ' Set stamp alignment (place stamp on page top, centered horiznotally)
            stamp1.VerticalAlignment = VerticalAlignment.Top
            stamp1.HorizontalAlignment = HorizontalAlignment.Center
            ' Specify the font style as Bold
            stamp1.TextState.FontStyle = FontStyles.Bold
            ' Set the text fore ground color information as red
            stamp1.TextState.ForegroundColor = Color.Red
            ' Specify the font size as 14
            stamp1.TextState.FontSize = 14

            ' Now we need to set the vertical alignment of 2nd stamp object as Top
            stamp2.VerticalAlignment = VerticalAlignment.Top
            ' Set Horizontal alignment information for stamp as Center aligned
            stamp2.HorizontalAlignment = HorizontalAlignment.Center
            ' Set the zooming factor for stamp object
            stamp2.Zoom = 10

            ' Set the formatting of 3rd stamp object
            ' Specify the Vertical alignment information for stamp object as TOP
            stamp3.VerticalAlignment = VerticalAlignment.Top
            ' Set the Horizontal alignment inforamtion for stamp object as Center aligned
            stamp3.HorizontalAlignment = HorizontalAlignment.Center
            ' Set the rotation angle for stamp object
            stamp3.RotateAngle = 35
            ' Set pink as background color for stamp
            stamp3.TextState.BackgroundColor = Color.Pink
            ' Change the font face information for stamp to Verdana
            stamp3.TextState.Font = FontRepository.FindFont("Verdana")
            ' First stamp is added on first page;
            doc.Pages(1).AddStamp(stamp1)
            ' Second stamp is added on second page;
            doc.Pages(2).AddStamp(stamp2)
            ' Third stamp is added on third page.
            doc.Pages(3).AddStamp(stamp3)
            dataDir = dataDir & Convert.ToString("multiheader_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:AddingDifferentHeaders 
            Console.WriteLine(Convert.ToString(vbLf & "Different headers added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
