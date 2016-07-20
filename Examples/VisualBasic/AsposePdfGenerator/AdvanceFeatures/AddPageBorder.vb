Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class AddPageBorder
        Public Shared Sub Run()
            ' ExStart:AddPageBorder
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Set the page border of the section using BorderInfo object 
            sec1.PageInfo.PageBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.2F)

            ' Set the left margin of page border of the section
            sec1.PageInfo.PageBorderMargin.Left = 20

            ' Add a text paragraph to the paragraphs collection of the section
            sec1.Paragraphs.Add(New Aspose.Pdf.Generator.Text("Hello World"))

            dataDir = dataDir & Convert.ToString("AddPageBorder_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:AddPageBorder           
        End Sub
    End Class
End Namespace
