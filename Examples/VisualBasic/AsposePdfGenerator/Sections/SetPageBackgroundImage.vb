Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Sections
    Public Class SetPageBackgroundImage
        Public Shared Sub Run()
            ' ExStart:SetPageBackgroundImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Sections()

            'Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Add a section into the pdf document
            Dim section1 As AP.Generator.Section = pdf.Sections.Add()

            ' Assign the image file path to BackgroundImageFile property of section
            section1.BackgroundImageFile = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Set the image type using ImageFileType enumeration
            section1.BackgroundImageType = AP.Generator.ImageFileType.Jpeg

            dataDir = dataDir & Convert.ToString("SetPageBackgroundImage_out_.pdf")

            'Save Pdf Document
            pdf.Save(dataDir)
            ' ExEnd:SetPageBackgroundImage
            Console.WriteLine(Convert.ToString(vbLf & "Page background image setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace