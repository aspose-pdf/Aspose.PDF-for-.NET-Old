Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToHTML
        Public Shared Sub Run()
            ' ExStart:PDFToHTML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Open the source PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))

            ' Save the file into MS document format
            pdfDocument.Save(dataDir & Convert.ToString("output_out_.html"), SaveFormat.Html)
            ' ExEnd:PDFToHTML
        End Sub
        Public Shared Sub MultiPageHTML()
            ' ExStart:MultiPageHTML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' open the source PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))

            ' Instantiate HTML SaveOptions object
            Dim htmlOptions As New HtmlSaveOptions()

            ' Specify to split the output into multiple pages
            htmlOptions.SplitIntoPages = True

            ' Save the document
            pdfDocument.Save("MultiPageHTML_out_.html", htmlOptions)
            ' ExEnd:MultiPageHTML
        End Sub
        Public Shared Sub SaveSVGFiles()
            ' ExStart:SaveSVGFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load the PDF file
            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))

            ' Instantiate HTML save options object
            Dim newOptions As New HtmlSaveOptions()

            ' Specify the folder where SVG images are saved during PDF to HTML conversion
            newOptions.SpecialFolderForSvgImages = dataDir

            ' Save the output file
            doc.Save(dataDir & Convert.ToString("SaveSVGFiles_out_.html"), newOptions)
            ' ExEnd:SaveSVGFiles
        End Sub
        Public Shared Sub CompressSVGImages()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load the PDF file
            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))
            ' ExStart:CompressSVGImages
            ' Create HtmlSaveOption with tested feature
            Dim newOptions As New HtmlSaveOptions()

            ' Compress the SVG images if there are any
            newOptions.CompressSvgGraphicsIfAny = True
            ' ExEnd:CompressSVGImages
            ' Save the output file
            doc.Save(dataDir & Convert.ToString("CompressSVGImages_out_.html"), newOptions)

        End Sub
        Public Shared Sub SpecifyingImageFolder()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load the PDF file
            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))
            ' ExStart:SpecifyingImageFolder
            ' Create HtmlSaveOption with tested feature
            Dim newOptions As New HtmlSaveOptions()

            ' Specify the separate folder to save images
            newOptions.SpecialFolderForAllImages = dataDir
            ' ExEnd:SpecifyingImageFolder
            ' Save the output file
            doc.Save(dataDir & Convert.ToString("SpecifyingImageFolder_out_.html"), newOptions)

        End Sub
        Public Shared Sub CreateSubsequentFiles()
            ' ExStart:CreateSubsequentFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))

            Dim options As New HtmlSaveOptions()
            ' This is the tested setting
            options.HtmlMarkupGenerationMode = HtmlSaveOptions.HtmlMarkupGenerationModes.WriteOnlyBodyContent
            options.SplitIntoPages = True

            doc.Save(dataDir & Convert.ToString("CreateSubsequentFiles_out_.html"), options)
            ' ExEnd:CreateSubsequentFiles
        End Sub
        Public Shared Sub TransparentTextRendering()
            ' ExStart:TransparentTextRendering
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))
            Dim htmlOptions As New HtmlSaveOptions()
            htmlOptions.SaveShadowedTextsAsTransparentTexts = True
            htmlOptions.SaveTransparentTexts = True
            doc.Save(dataDir & Convert.ToString("TransparentTextRendering_out_.html"), htmlOptions)
            ' ExEnd:TransparentTextRendering
        End Sub
        Public Shared Sub LayersRendering()
            ' ExStart:LayersRendering
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            Dim doc As New Document(dataDir & Convert.ToString("PDFToHTML.pdf"))
            ' Instantiate HTML SaveOptions object
            Dim htmlOptions As New HtmlSaveOptions()

            ' Specify to render PDF document layers separately in output HTML
            htmlOptions.ConvertMarkedContentToLayers = True

            ' Save the document
            doc.Save(dataDir & Convert.ToString("LayersRendering_out_.html"), htmlOptions)
            ' ExEnd:LayersRendering
        End Sub
    End Class
End Namespace