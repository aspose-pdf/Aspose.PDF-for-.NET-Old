Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ConcatenatePDFForms
        Public Shared Sub Run()
            ' ExStart:ConcatenatePDFForms
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Set input and output file paths
            Dim inputFile1 As String = dataDir & Convert.ToString("inFile1.pdf")
            Dim inputFile2 As String = dataDir & Convert.ToString("inFile2.pdf")
            Dim outFile As String = dataDir & Convert.ToString("ConcatenatePDFForms_out_.pdf")

            ' Instantiate PdfFileEditor Object
            Dim fileEditor As New PdfFileEditor()
            ' To keep unique field Id for all the fields 
            fileEditor.KeepFieldsUnique = True
            ' Format of the suffix which is added to field name to make it unique when forms are concatenated.
            fileEditor.UniqueSuffix = "_%NUM%"

            ' Concatenate the files into a resultant Pdf file
            fileEditor.Concatenate(inputFile1, inputFile2, outFile)
            ' ExEnd:ConcatenatePDFForms                      
        End Sub
    End Class
End Namespace
