Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Drawing

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class ImageToPdf
        Public Shared Sub Run()
            ' ExStart:ImageToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create an image object in the section
            Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

            ' Add image object into the Paragraphs collection of the section
            sec1.Paragraphs.Add(image1)

            ' Set the path of image file
            image1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

            ' Set image title
            image1.ImageInfo.Title = "JPEG image"

            ' Save the Pdf file
            pdf1.Save(dataDir & Convert.ToString("JPGImageToPdf_out_.pdf"))
            ' ExEnd:ImageToPdf           
        End Sub
        Public Shared Sub ConvertBMPImageToPdf()
            ' ExStart:ConvertBMPImageToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Create a PDF object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Create a section and add it to pdf document
            Dim MainSection As Aspose.Pdf.Generator.Section = pdf.Sections.Add()
            ' Create an image object
            Dim sample_image As New Aspose.Pdf.Generator.Image()
            ' Specify the image file path information
            sample_image.ImageInfo.File = dataDir & Convert.ToString("barbara_gray.bmp")
            ' Specify the image file type
            sample_image.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp
            ' Specify the image width information equal to page width 
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageWidth - MainSection.PageInfo.Margin.Left - MainSection.PageInfo.Margin.Right
            ' Specify the image Height information equal to page Height
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageHeight - MainSection.PageInfo.Margin.Top - MainSection.PageInfo.Margin.Bottom

            ' Create bitmap image object to load image information
            Dim myimage As New Bitmap(dataDir & Convert.ToString("barbara_gray.bmp"))
            ' Check if the width of the image file is greater than Page width or not
            If myimage.Width > MainSection.PageInfo.PageWidth Then
                ' If the Image width is greater than page width, then set the page orientation to Landscape
                MainSection.IsLandscape = True
            Else
                ' If the Image width is less than page width, then set the page orientation to Portrait
                MainSection.IsLandscape = False
            End If

            ' Add image to paragraphs collection of section
            MainSection.Paragraphs.Add(sample_image)
            ' Save the resultant PDF
            pdf.Save(dataDir & Convert.ToString("ConvertBMPImageToPdf_out_.pdf"))
            ' ExEnd:ConvertBMPImageToPdf
        End Sub
    End Class
End Namespace
