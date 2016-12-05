Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Sections
    Public Class SetHeaderAndFooter
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Sections()

            ' Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Add a section into the pdf document
            Dim section1 As AP.Generator.Section = pdf.Sections.Add()
            ' ExStart:SetHeaderAndFooter
            ' Instantiate HeaderFooter object and pass the Section reference in which
            ' The header or footer is to be added
            Dim hf1 As New AP.Generator.HeaderFooter(section1)

            ' Set the header of odd pages of the PDF document
            section1.OddHeader = hf1

            ' Set the header of even pages of the PDF document
            section1.EvenHeader = hf1

            ' Instantiate a Text paragraph that will store the content to show as header
            Dim text As New AP.Generator.Text(hf1, "header")

            ' Add the text object to the Paragraphs collection of HeaderFooter object to
            ' Display header on the pages of PDF document
            hf1.Paragraphs.Add(text)
            ' ExEnd:SetHeaderAndFooter
            dataDir = dataDir & Convert.ToString("SetHeaderAndFooter_out_.pdf")

            ' Save Pdf Document
            pdf.Save(dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "Header and footer setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace