Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.UtilityFeatures
    Public Class CreatePdf
        Public Shared Sub Run()
            ' ExStart:CreatePdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Create a file stream to create the PDF document
            Dim fs As New FileStream(dataDir & Convert.ToString("SingleSeg-d_out_.pdf"), FileMode.Create)

            ' Instantiate the Pdf instance and pass the file stream object to its constructor
            Dim pdf As New Aspose.Pdf.Generator.Pdf(fs)

            ' Add a section to the PDF document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Add 1000 text paragraphs to the section
            For i As Integer = 0 To 999
                Dim t As New Aspose.Pdf.Generator.Text("hello world hello world hello " + i.ToString())
                sec1.AddParagraph(t)
            Next

            ' Close the Pdf. This method is used only for direct file mode
            pdf.Close()
            ' ExEnd:CreatePdf           
        End Sub
        Public Shared Sub UsingXML()
            ' ExStart:UsingXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()
            ' Create a file stream to create the PDF document
            Dim fs As New FileStream(dataDir & Convert.ToString("CreatePdfUsingXML_out_"), FileMode.Create)

            'Instantiate the Pdf instance and pass the file stream object to its constructor
            Dim pdf As New Aspose.Pdf.Generator.Pdf(fs)

            ' Bind the XML file to the Pdf and leave the XSL file parameter as Nothing
            pdf.BindXML(dataDir & Convert.ToString("log.xml"), Nothing)

            ' Close the Pdf. This method is used only for direct file mode
            pdf.Close()
            ' ExEnd:UsingXML
        End Sub

    End Class
End Namespace