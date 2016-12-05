Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class CompleteClone
        Public Shared Sub Run()
            ' ExStart:CompleteClone
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Call BindXML method to read information from RepeatExample.xml document. Second
            ' Parameter is for Xsl file. In our case, we don' T need it so leave it as null.
            pdf1.BindXML(dataDir & Convert.ToString("RepeatExample.xml"), Nothing)

            ' Obtain the first section from the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections(0)

            ' Obtain a table named "table1" from the Pdf
            Dim table1 As Aspose.Pdf.Generator.Table = TryCast(sec1.Paragraphs("table1"), Aspose.Pdf.Generator.Table)

            ' Declare a table instance
            Dim curTable As Aspose.Pdf.Generator.Table

            ' Create an array of string containing three values, "item1", "item2" and "item3"
            Dim items As String() = New String() {"item1", "item2", "item3"}

            ' Run a for loop for 5 times
            For i As Integer = 0 To 4
                ' Copy the table structure of "table1" by calling its Clone method
                curTable = TryCast(table1.Clone(), Aspose.Pdf.Generator.Table)

                ' Set the top margin of the cloned table to 10
                curTable.Margin.Top = 10

                ' Copy a row (with structure and data) of "table1" by calling its
                ' CompleteClone method. And then add that row to the cloned table
                curTable.Rows.Add(TryCast(table1.Rows(0).CompleteClone(), Aspose.Pdf.Generator.Row))

                ' Import an array of string "items" into the table
                curTable.ImportArray(items, 1, 0, False)

                ' Add the cloned table to the paragraphs collection of the section
                sec1.Paragraphs.Add(curTable)
            Next

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("CompleteClone_out_.pdf"))
            ' ExEnd:CompleteClone   

        End Sub
    End Class
End Namespace