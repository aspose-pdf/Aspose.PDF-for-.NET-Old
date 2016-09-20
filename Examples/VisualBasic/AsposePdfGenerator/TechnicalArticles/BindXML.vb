Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Xml

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class BindXML
        Public Shared Sub Run()
            ' ExStart:BindXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            Dim xmlDoc As New XmlDocument()
            xmlDoc.LoadXml(dataDir & Convert.ToString("Sample.xml"))

            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            ' Object xmlDoc contains all contents from original word document in XML format defined in Aspose.PDF XML Schema. 
            pdf.BindXML(xmlDoc, Nothing)

            ' Before saving, to add bookmarks from headings. 
            pdf.IsBookmarked = True

            For Each sec As Aspose.Pdf.Generator.Section In pdf.Sections
                For Each para As Aspose.Pdf.Generator.Paragraph In sec.Paragraphs
                    If TypeOf para Is Aspose.Pdf.Generator.Heading Then
                        Dim h As Aspose.Pdf.Generator.Heading = TryCast(para, Aspose.Pdf.Generator.Heading)
                        h.IsInList = True
                    End If
                Next
            Next
            pdf.Save(dataDir & Convert.ToString("BindXML_out_.pdf"))
            ' ExEnd:BindXML           
        End Sub
    End Class
End Namespace
