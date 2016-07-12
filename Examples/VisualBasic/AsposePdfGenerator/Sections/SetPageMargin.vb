Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Sections
    Public Class SetPageMargin
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Sections()

            ' Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Add a section into the pdf document
            Dim section1 As AP.Generator.Section = pdf.Sections.Add()
            ' ExStart:SetPageMargin
            ' Instantiate the MarginInfo instance
            Dim marginInfo As New AP.Generator.MarginInfo()

            ' Set the margin Top. This value is in points but other units like
            ' Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Top = 72

            ' Set the margin Bottom. This value is in points but other units like
            ' Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Bottom = 72

            ' Set the margin Left. This value is in points but other units like
            ' Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Left = 90

            ' Set the margin Right. This value is in points but other units like
            ' Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Right = 90

            ' Assign the marginInfo instance to Margin property of sec1.PageInfo
            section1.PageInfo.Margin = marginInfo
            ' ExEnd:SetPageMargin
            dataDir = dataDir & Convert.ToString("SetPageMargin_out_.pdf")

            'Save Pdf Document
            pdf.Save(dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "Page margin setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
