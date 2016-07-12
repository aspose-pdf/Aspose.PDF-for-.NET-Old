Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Sections
    Public Class SetPageSize
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Sections()

            ' Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Add a section into the pdf document
            Dim section1 As AP.Generator.Section = pdf.Sections.Add()

            ' ExStart:SetPageSize
            section1.PageInfo.PageWidth = AP.Generator.PageSize.A3Width
            section1.PageInfo.PageHeight = AP.Generator.PageSize.A3Height
            ' ExEnd:SetPageSize
            ' OR 
            ' ExStart:SetPageSize-1
            section1.PageInfo.PageWidth = 576
            section1.PageInfo.PageHeight = 707.5F
            ' ExEnd:SetPageSize-1

            dataDir = dataDir & Convert.ToString("SetPageSize_out_.pdf")

            'Save Pdf Document
            pdf.Save(dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "Page size setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
