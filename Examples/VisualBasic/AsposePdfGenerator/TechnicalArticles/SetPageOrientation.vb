Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Drawing

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class SetPageOrientation
        Public Shared Sub Run()
            ' ExStart:SetPageOrientation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            ' Retrieve names of all the Pdf files in a particular Directory
            Dim fileEntries As String() = Directory.GetFiles(dataDir, "*.JPG")

            Dim counter As Integer
            For counter = 0 To fileEntries.Length - 2
                ' Create a section object
                Dim section1 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

                ' Creat an image object
                Dim image1 As New Aspose.Pdf.Generator.Image(section1)
                image1.ImageInfo.File = fileEntries(counter)
                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

                ' Create a BitMap object in order to get the information of image file
                Dim myimage As New Bitmap(fileEntries(counter))
                ' Check if the width of the image file is greater than Page width or not
                If myimage.Width > section1.PageInfo.PageWidth Then
                    ' If the Image width is greater than page width, then set the page orientation to Landscape
                    section1.IsLandscape = True
                Else
                    ' If the Image width is less than page width, then set the page orientation to Portrait
                    section1.IsLandscape = False
                End If
                ' Add the image to paragraphs collection of the PDF document 
                section1.Paragraphs.Add(image1)
            Next
            ' Save the Pdf file
            pdf.Save(dataDir & Convert.ToString("SetPageOrientation_out_.pdf"))
            ' ExEnd:SetPageOrientation           
        End Sub
    End Class
End Namespace

