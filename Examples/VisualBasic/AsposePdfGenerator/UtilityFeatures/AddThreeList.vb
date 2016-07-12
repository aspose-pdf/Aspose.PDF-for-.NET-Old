Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.UtilityFeatures
    Public Class AddThreeList
        Public Shared Sub Run()
            ' ExStart:AddThreeList
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a list section
            Dim tocSection As New Aspose.Pdf.Generator.ListSection("Table Of Contents")

            ' Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents

            ' Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection)

            ' Create a list section
            Dim lotSection As New Aspose.Pdf.Generator.ListSection("List of Tables")


            ' Set its list type as list of tables
            lotSection.ListType = Aspose.Pdf.Generator.ListType.ListOfTables

            ' Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(lotSection)

            ' Create a list section
            Dim lofSection As New Aspose.Pdf.Generator.ListSection("List of Figures")

            ' Set its list type as list of figures
            lofSection.ListType = Aspose.Pdf.Generator.ListType.ListOfFigures

            ' Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(lofSection)

            dataDir = dataDir & Convert.ToString("AddThreeList_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:AddThreeList           
        End Sub

    End Class
End Namespace