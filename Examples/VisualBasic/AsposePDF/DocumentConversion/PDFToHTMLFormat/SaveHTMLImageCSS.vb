Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SaveHTMLImageCSS
        Public Shared Sub Run()
            Try
                ' ExStart:SaveHTMLImageCSS
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Pay attention that we put non-existing path here : since we use custon resource processing it won't be in use.
                ' If You forget implement some of required saving strategies(CustomHtmlSavingStrategy,CustomResourceSavingStrategy,CustomCssSavingStrategy), then saving will return "Path not found" exception
                Dim outHtmlFile As String = dataDir & Convert.ToString("SaveHTMLImageCSS_out_.html")

                ' Create HtmlSaveOption with custom saving strategies that will do all the saving job
                ' in such approach You can split HTML in pages if You will
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.SplitIntoPages = True

                saveOptions.CustomHtmlSavingStrategy = New HtmlSaveOptions.HtmlPageMarkupSavingStrategy(AddressOf StrategyOfSavingHtml)
                saveOptions.CustomResourceSavingStrategy = New HtmlSaveOptions.ResourceSavingStrategy(AddressOf CustomSaveOfFontsAndImages)
                saveOptions.CustomStrategyOfCssUrlCreation = New HtmlSaveOptions.CssUrlMakingStrategy(AddressOf CssUrlMakingStrategy)
                saveOptions.CustomCssSavingStrategy = New HtmlSaveOptions.CssSavingStrategy(AddressOf CustomSavingOfCss)

                saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground
                doc.Save(outHtmlFile, saveOptions)

                Console.WriteLine("Done")
                ' ExEnd:SaveHTMLImageCSS
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:SaveHTMLImageCSSHelper
        Private Shared Sub StrategyOfSavingHtml(htmlSavingInfo As HtmlSaveOptions.HtmlPageMarkupSavingInfo)
            ' Get target file name and write content to it
            Dim reader As System.IO.BinaryReader = New BinaryReader(htmlSavingInfo.ContentStream)
            Dim htmlAsByte As Byte() = reader.ReadBytes(CInt(htmlSavingInfo.ContentStream.Length))
            Console.WriteLine("Html page processed with handler. Length of page's text in bytes is " + htmlAsByte.Length.ToString())

            ' Here You can put code that will save page's HTML to some storage, f.e database
            Dim targetStream As New MemoryStream()
            targetStream.Write(htmlAsByte, 0, htmlAsByte.Length)
        End Sub
        Private Shared Function CssUrlMakingStrategy(requestInfo As HtmlSaveOptions.CssUrlRequestInfo) As String
            Dim template As String = "style{0}.css"
            ' One more example of template :
            ' String template = "http://localhost:24661/document-viewer/GetResourceForHtmlHandler?documentPath=Deutschland201207Arbeit.pdf&resourcePath=style{0}.css&fileNameOnly=false";
            Return template
        End Function

        Private Shared Sub CustomSavingOfCss(resourceInfo As HtmlSaveOptions.CssSavingInfo)
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceInfo.ContentStream)
            Dim cssAsBytes As Byte() = reader.ReadBytes(CInt(resourceInfo.ContentStream.Length))
            Console.WriteLine("Css page processed with handler. Length of css in bytes is " + cssAsBytes.Length.ToString())

            ' Here You can put code that will save page's HTML to some storage, f.e database
            Dim targetStream As New MemoryStream()
            targetStream.Write(cssAsBytes, 0, cssAsBytes.Length)
        End Sub

        Private Shared Function CustomSaveOfFontsAndImages(resourceSavingInfo As SaveOptions.ResourceSavingInfo) As String
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceSavingInfo.ContentStream)
            Dim resourceAsBytes As Byte() = reader.ReadBytes(CInt(resourceSavingInfo.ContentStream.Length))

            If resourceSavingInfo.ResourceType = SaveOptions.NodeLevelResourceType.Font Then
                Console.WriteLine("Font processed with handler. Length of content in bytes is " + resourceAsBytes.Length.ToString())
                ' Here You can put code that will save font to some storage, f.e database
                Dim targetStream As New MemoryStream()
                targetStream.Write(resourceAsBytes, 0, resourceAsBytes.Length)
            ElseIf resourceSavingInfo.ResourceType = SaveOptions.NodeLevelResourceType.Image Then
                Console.WriteLine("Image processed with handler. Length of content in bytes is " + resourceAsBytes.Length.ToString())
                ' Here You can put code that will save image to some storage, f.e database
                Dim targetStream As New MemoryStream()
                targetStream.Write(resourceAsBytes, 0, resourceAsBytes.Length)
            End If

            ' We should return URI bt which resource will be referenced in CSS(for font)
            ' or HTML(for images)
            '  This  is very siplistic way - here we just return file name or resource.
            '  You can put here some URI that will include ID of resource in database etc. 
            '  - this URI will be added into result CSS or HTML to refer the resource
            Return resourceSavingInfo.SupposedFileName
        End Function
        ' ExEnd:SaveHTMLImageCSSHelper
    End Class
End Namespace