Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Sections
    Public Class AdvancedHeaderAndFooter
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Sections()

            ' Instantiate a PDF Object 
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a Section object by calling Add method of Sections collection of Pdf class
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Instantiate First HeaderFooter object and pass the Section reference in which
            ' the header or footer is to be added
            Dim hf1 As New AP.Generator.HeaderFooter(sec1)

            ' Set the header of odd pages of the PDF document
            sec1.OddHeader = hf1

            ' Set the header of even pages of the PDF document
            sec1.EvenHeader = hf1

            ' Enable this header for first page only
            hf1.IsFirstPageOnly = True

            ' Add Distance From Edge Property to 80 unit Points
            hf1.DistanceFromEdge = 80

            ' Set the First HeaderFooter, top and bottom property respectively
            hf1.Margin.Bottom = 50
            hf1.Margin.Top = 100

            ' Instantiate a Text paragraph that will store the content to show as header
            Dim text As New AP.Generator.Text(hf1, "header for first page")

            ' Add the text object to the Paragraphs collection of HeaderFooter object to
            ' display header on the pages of PDF document
            hf1.Paragraphs.Add(text)

            '
            '             *Second Header "hf2" for odd subsequent pages only
            '             


            ' Instantiate Second HeaderFooter object and pass the Section reference in which
            ' the header or footer is to be added
            Dim hf2 As New AP.Generator.HeaderFooter(sec1)

            ' Set the additional header of odd pages of the PDF document
            sec1.AdditionalOddHeader = hf2

            ' Enable this header for subsequent page only
            hf2.IsSubsequentPagesOnly = True

            ' Add Distance From Edge Property of header to 150 unit Points
            hf2.DistanceFromEdge = 150
            hf2.Margin.Bottom = 70

            ' Instantiate a Text paragraph that will store the content to show as header
            text = New AP.Generator.Text(hf2, "odd header for subsequent pages")

            ' Add the text object to the Paragraphs collection of HeaderFooter object to
            ' display header on the pages of PDF document
            hf2.Paragraphs.Add(text)

            '
            '             *Third Header "hf3" for even subsequent pages only
            '             


            ' Instantiate Third HeaderFooter object and pass the Section reference in which
            ' the header or footer is to be added
            Dim hf3 As New AP.Generator.HeaderFooter(sec1)

            ' Set the additional header of even pages of the PDF document
            sec1.AdditionalEvenHeader = hf3

            ' Enable this header for subsequent page only
            hf3.IsSubsequentPagesOnly = True

            ' Add the Distance from Edge for the third Header
            hf3.DistanceFromEdge = 180
            hf3.Margin.Top = 90

            ' Instantiate a Text paragraph that will store the content to show as header
            text = New AP.Generator.Text(hf3, "even header for subsequent pages")

            ' Add the text object to the Paragraphs collection of HeaderFooter object to
            ' display header on the pages of PDF document
            hf3.Paragraphs.Add(text)

            ' ExEnd:SetHeaderAndFooter
            dataDir = dataDir & Convert.ToString("AdvancedHeaderAndFooter_out_.pdf")

            'Save Pdf Document
            pdf1.Save(dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "Advanced header and footer setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace