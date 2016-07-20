Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Drawing

Namespace AsposePDF.Images
    Public Class ImagePlacements
        Public Shared Sub Run()
            ' ExStart:ImagePlacements
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()


            ' Load the source PDF document
            Dim doc As New Document(dataDir & Convert.ToString("ImagePlacement.pdf"))
            Dim abs As New ImagePlacementAbsorber()

            ' Load the contents of first page
            ' ExStart:ExtractImageFromIndividualPage
            doc.Pages(1).Accept(abs)
            ' ExEnd:ExtractImageFromIndividualPage
            For Each imagePlacement As ImagePlacement In abs.ImagePlacements
                ' Get image properties
                Console.Out.WriteLine("image width:" + imagePlacement.Rectangle.Width.ToString())
                Console.Out.WriteLine("image height:" + imagePlacement.Rectangle.Height.ToString())
                Console.Out.WriteLine("image LLX:" + imagePlacement.Rectangle.LLX.ToString())
                Console.Out.WriteLine("image LLY:" + imagePlacement.Rectangle.LLY.ToString())
                Console.Out.WriteLine("image horizontal resolution:" + imagePlacement.Resolution.X.ToString())
                Console.Out.WriteLine("image vertical resolution:" + imagePlacement.Resolution.Y.ToString())

                ' Retrieve image with visible dimensions
                Dim scaledImage As Bitmap
                Using imageStream As New MemoryStream()
                    ' Retrieve image from resources
                    imagePlacement.Image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png)
                    Dim resourceImage As Bitmap = DirectCast(Bitmap.FromStream(imageStream), Bitmap)
                    ' Create bitmap with actual dimensions
                    scaledImage = New Bitmap(resourceImage, CInt(imagePlacement.Rectangle.Width), CInt(imagePlacement.Rectangle.Height))
                End Using
            Next
            ' ExEnd:ImagePlacements            
        End Sub
    End Class
End Namespace
