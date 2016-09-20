Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Drawing

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class PerformaceImprovement
        Public Shared Sub Run()
            ' ExStart:PerformaceImprovement
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Get a list of tiff image files
            Dim files As String() = System.IO.Directory.GetFiles(dataDir)

            ' Instantiate a Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Navigate through the files and them in the pdf file
            For Each myFile As String In files

                ' Load all tiff files in byte array
                Dim fs As New FileStream(myFile, FileMode.Open, FileAccess.Read)
                Dim tmpBytes As Byte() = New Byte(Convert.ToInt32(fs.Length - 1)) {}
                fs.Read(tmpBytes, 0, Convert.ToInt32(fs.Length))

                Dim mystream As New MemoryStream(tmpBytes)
                Dim b As New Bitmap(mystream)
                ' Create a new section in the Pdf document
                Dim sec1 As New Aspose.Pdf.Generator.Section(pdf1)

                ' Set margins so image will fit, etc.
                sec1.PageInfo.Margin.Top = 5
                sec1.PageInfo.Margin.Bottom = 5
                sec1.PageInfo.Margin.Left = 5
                sec1.PageInfo.Margin.Right = 5

                sec1.PageInfo.PageWidth = (b.Width / b.HorizontalResolution) * 72
                sec1.PageInfo.PageHeight = (b.Height / b.VerticalResolution) * 72

                ' Add the section in the sections collection of the Pdf document
                pdf1.Sections.Add(sec1)

                ' Create an image object
                Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

                ' Add the image into paragraphs collection of the section
                sec1.Paragraphs.Add(image1)
                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Tiff

                ' Set IsBlackWhite property to true for performance improvement
                image1.ImageInfo.IsBlackWhite = True
                ' Set the ImageStream to a MemoryStream object
                image1.ImageInfo.ImageStream = mystream
                ' Set desired image scale
                image1.ImageScale = 0.95F
            Next

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("PerformaceImprovement_out_.pdf"))
            ' ExEnd:PerformaceImprovement           
        End Sub
    End Class
End Namespace
