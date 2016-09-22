Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.TechnicalArticles
    Public Class CreatePDFPortfolio
        Public Shared Sub Run()
            ' ExStart:CreatePDFPortfolio
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_TechnicalArticles()

            ' Instantiate Document Object
            Dim doc As New Document()

            ' Instantiate document Collection object
            doc.Collection = New Collection()

            ' Get Files to add to Portfolio
            Dim excel As New FileSpecification(dataDir & "HelloWorld.xlsx")
            Dim word As New FileSpecification(dataDir & "HelloWorld.docx")
            Dim image As New FileSpecification(dataDir & "aspose-logo.jpg")

            ' Provide description of the files
            excel.Description = "Excel File"
            word.Description = "Word File"
            image.Description = "Image File"

            ' Add files to document collection
            doc.Collection.Add(excel)
            doc.Collection.Add(word)
            doc.Collection.Add(image)

            ' Save Portfolio document
            doc.Save(dataDir & "CreatePDFPortfolio_out_.pdf")
            ' ExEnd:CreatePDFPortfolio                      
        End Sub
    End Class
End Namespace
