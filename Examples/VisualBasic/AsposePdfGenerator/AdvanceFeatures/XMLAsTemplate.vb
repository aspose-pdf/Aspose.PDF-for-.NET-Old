Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class XMLAsTemplate
        Public Shared Sub Run()
            ' ExStart:XMLAsTemplate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            ' Create a Pdf instance and bind the XML template file to Pdf instance
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            pdf1.BindXML(dataDir & Convert.ToString("Template.xml"), Nothing)

            ' Get the section and then table from the obtained section of the Pdf that
            ' is built from the XML template
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections("Section1")
            Dim table1 As Aspose.Pdf.Generator.Table = TryCast(sec1.Paragraphs("Table1"), Aspose.Pdf.Generator.Table)

            ' Clone a new table 
            Dim table2 As Aspose.Pdf.Generator.Table = TryCast(table1.CompleteClone(), Aspose.Pdf.Generator.Table)

            ' Change the ID of table2 to "Table2" to make it different from table1 
            table2.ID = "Table2"

            ' Add table2 into the section
            sec1.Paragraphs.Add(table2)

            ' Now there are 2 segments with ID "Item",
            ' We change the IDs to make sure they are different 
            Dim item As Aspose.Pdf.Generator.Segment = TryCast(sec1.GetObjectByID("Item"), Aspose.Pdf.Generator.Segment)
            item.ID = "Item1"
            item = TryCast(sec1.GetObjectByID("Item"), Aspose.Pdf.Generator.Segment)
            item.ID = "Item2"

            ' Change the content 
            item.Content = "item 2"

            ' Now clone section1 
            Dim sec2 As Aspose.Pdf.Generator.Section = TryCast(sec1.CompleteClone(), Aspose.Pdf.Generator.Section)

            ' Add a cloned section to the Pdf and change the contents of the text segments
            ' in the section2 of the Pdf object        
            pdf1.Sections.Add(sec2)
            item = TryCast(sec2.GetObjectByID("Item1"), Aspose.Pdf.Generator.Segment)
            item.Content = "item1 sec2"
            item = TryCast(sec2.GetObjectByID("Item2"), Aspose.Pdf.Generator.Segment)
            item.Content = "item2 sec2"

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("XmlTemp_out_.pdf"))
            ' ExEnd:XMLAsTemplate           
        End Sub
    End Class
End Namespace