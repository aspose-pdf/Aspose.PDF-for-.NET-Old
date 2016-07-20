Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class TableMinimumColumnWidth
        Public Shared Sub Run()
            ' ExStart:TableMinimumColumnWidth
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a table object and add it to the paragraphs collection of the section        
            Dim tab1 As New Aspose.Pdf.Generator.Table()
            sec1.Paragraphs.Add(tab1)

            ' Set the column widths and default cell border of the table
            tab1.ColumnWidths = "60 100 100"
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 1.0F)

            ' Prepare an array of string values to be added to table
            Dim darr As String() = New String() {"Owner/Marketing Assistant", "dhasf hh ddt", "dhaosdha djsd dsads", "dsd dajd", "hdsah jj jj jdj", "ddfa jjj jhdusa"}

            ' Import the contents of the array created in above step
            tab1.ImportArray(darr, 0, 0, True)

            ' Call GetMinColumnWidth and pass the column number whose minimum width is needed
            Dim width As Single = tab1.GetMinColumnWidth(pdf1, 0)

            ' Call SetColumnWidth and pass the column number with minimum width
            tab1.SetColumnWidth(0, width)

            dataDir = dataDir & Convert.ToString("TableMinimumColumnWidth_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:TableMinimumColumnWidth           
        End Sub
    End Class
End Namespace
