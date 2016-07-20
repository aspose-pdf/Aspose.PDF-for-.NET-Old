Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.Images
    Public Class SearchAndGetImages
        Public Shared Sub Run()
            ' ExStart:SearchAndGetImages 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("SearchAndGetImages.pdf"))

            ' Create ImagePlacementAbsorber object to perform image placement search
            Dim abs As New ImagePlacementAbsorber()

            ' Accept the absorber for all the pages
            doc.Pages.Accept(abs)

            ' Loop through all ImagePlacements, get image and ImagePlacement Properties
            For Each imagePlacement As ImagePlacement In abs.ImagePlacements
                ' Get the image using ImagePlacement object
                Dim image As XImage = imagePlacement.Image

                ' Display image placement properties for all placements
                Console.Out.WriteLine("image width:" + imagePlacement.Rectangle.Width.ToString())
                Console.Out.WriteLine("image height:" + imagePlacement.Rectangle.Height.ToString())
                Console.Out.WriteLine("image LLX:" + imagePlacement.Rectangle.LLX.ToString())
                Console.Out.WriteLine("image LLY:" + imagePlacement.Rectangle.LLY.ToString())
                Console.Out.WriteLine("image horizontal resolution:" + imagePlacement.Resolution.X.ToString())
                Console.Out.WriteLine("image vertical resolution:" + imagePlacement.Resolution.Y.ToString())
            Next
            ' ExEnd:SearchAndGetImages 
        End Sub
    End Class
End Namespace
