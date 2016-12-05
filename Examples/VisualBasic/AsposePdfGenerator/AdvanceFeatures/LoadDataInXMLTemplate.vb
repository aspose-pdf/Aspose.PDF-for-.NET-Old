Imports System.IO
Imports System
Imports System.Data
Imports Aspose.Pdf

Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class LoadDataInXMLTemplate
        Public Shared Sub Run()
            ' ExStart:LoadDataInXMLTemplate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            ' Creating a new Pdf object
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            ' Binding the content from the named XML file
            pdf.BindXML(dataDir & Convert.ToString("Sample.xml"), Nothing)

            ' In a real scenario, data is usually input from Database. So, we can get data
            ' From a database. In this case, we are using a method that will provide us an
            ' Instance of DataTable. The implementation of this method is also given below.
            Dim getDT As DataTable = creatDataTable()

            ' Accessing a table through its ID
            Dim contenTable As Aspose.Pdf.Generator.Table = DirectCast(pdf.GetObjectByID("Content"), Aspose.Pdf.Generator.Table)

            ' Importing data from a DataTable and filling the table in PDF document
            contenTable.ImportDataTable(getDT, False, 1, 1, 5, 4)

            ' Saving the results
            pdf.Save(dataDir & Convert.ToString("Sample_out_.pdf"))
            ' ExEnd:LoadDataInXMLTemplate
        End Sub
        ' ExStart:creatDataTable
        ' The implementation of createDataTable method that is being called in the program
        Public Shared Function creatDataTable() As DataTable

            ' Creating a DataTable object
            Dim dt As New DataTable("Sample")

            ' Adding columns to the DataTable
            dt.Columns.Add("Beginning of lease", GetType(Int32))
            dt.Columns.Add("End of lease", GetType(Int32))
            dt.Columns.Add("Landlord' S end-of-lease assessment", GetType(String))
            dt.Columns.Add("Comments", GetType(String))

            ' Adding rows to the DataTable
            Dim dr As DataRow = dt.NewRow()
            dr(0) = 12
            dr(1) = 11
            dr(2) = "$32.38"
            dr(3) = "M"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr(0) = 22
            dr(1) = 22
            dr(2) = "$148.45"
            dr(3) = "G"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr(0) = 41
            dr(1) = 41
            dr(2) = "$11.42"
            dr(3) = "S,R"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr(0) = 47
            dr(1) = 40
            dr(2) = "$48.52"
            dr(3) = "D"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr(0) = 28
            dr(1) = 20
            dr(2) = "$78.43"
            dr(3) = "R"
            dt.Rows.Add(dr)

            ' Returning the instance of DataTable object
            Return dt

        End Function
        ' ExEnd:creatDataTable
    End Class
End Namespace
