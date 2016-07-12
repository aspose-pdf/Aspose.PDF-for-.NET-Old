Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports System.Text
Imports System.Xml

Namespace AsposePdfGenerator.Text
    Public Class InlineHTMLFromXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create pdf document
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Bind XML into the document
            pdf1.BindXML(dataDir & "InlineHTMLFromXML.xml", Nothing)

            ' Save the document
            pdf1.Save(dataDir & "test_out_.pdf")
        End Sub
    End Class
End Namespace

