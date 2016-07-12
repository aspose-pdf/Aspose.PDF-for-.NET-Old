Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Drawing.Imaging
Namespace AsposePDF.Images
    Public Class IdentifyImages
        Public Shared Sub Run()
            ' ExStart:IdentifyImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Counter for grayscale images
            Dim grayscaled As Integer = 0
            ' Counter for RGB images
            Dim rgd As Integer = 0

            Using document As New Document(dataDir & Convert.ToString("ExtractImages.pdf"))
                For Each page As Page In document.Pages
                    Console.WriteLine("--------------------------------")
                    Dim abs As New ImagePlacementAbsorber()
                    page.Accept(abs)
                    ' Get the count of images over specific page
                    Console.WriteLine("Total Images = {0} over page number {1}", abs.ImagePlacements.Count, page.Number)
                    ' Document.Pages[29].Accept(abs);
                    Dim image_counter As Integer = 1
                    For Each ia As ImagePlacement In abs.ImagePlacements
                        Dim colorType__1 As ColorType = ia.Image.GetColorType()
                        Select Case colorType__1
                            Case ColorType.Grayscale
                                grayscaled += 1
                                Console.WriteLine("Image {0} is GrayScale...", image_counter)
                                Exit Select
                            Case ColorType.Rgb
                                rgd += 1
                                Console.WriteLine("Image {0} is RGB...", image_counter)
                                Exit Select
                        End Select
                        image_counter += 1
                    Next
                Next
            End Using
            ' ExEnd:IdentifyImages
        End Sub
    End Class
End Namespace
