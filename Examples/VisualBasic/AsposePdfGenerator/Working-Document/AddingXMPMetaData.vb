Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.WorkingDocuments
    Public Class AddingXMPMetaData
        Public Shared Sub Run()
            ' ExStart:AddingXMPMetaData
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Add a section into the pdf document
            Dim section1 As AP.Generator.Section = pdf.Sections.Add()

            ' Create a sample text paragraph
            Dim text1 As New AP.Generator.Text("This is a test for XMP Metadata")
            ' Add text paragraph to paragraphs collection of section object
            section1.Paragraphs.Add(text1)

            ' Create XmpMetaData object
            pdf.XmpMetadata = New AP.Generator.XmpMetadata()

            ' Core properties
            pdf.XmpMetadata.AddCreationDate(System.DateTime.Now.ToString())

            ' User properties
            pdf.XmpMetadata.AddUserProperty("xmlns:dc=""http://purl.org/dc/elements/1.1/""", "dc:contributor", "Aspose")

            dataDir = dataDir & Convert.ToString("AddingXMPMetaData_out_.pdf")
            ' Save Pdf Document
            pdf.Save(dataDir)
            ' ExEnd:AddingXMPMetaData
            Console.WriteLine(Convert.ToString(vbLf & "XMP metadata setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace