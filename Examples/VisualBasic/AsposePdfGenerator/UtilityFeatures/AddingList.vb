Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.UtilityFeatures
    Public Class AddingList
        Public Shared Sub Run()
            ' ExStart:AddingList
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

            dataDir = dataDir & Convert.ToString("AddingList_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:AddingList           
        End Sub
        Public Shared Sub DefineFormat()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a list section 
            Dim tocSection As New Aspose.Pdf.Generator.ListSection("Table Of Contents")

            ' Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents

            ' ExStart:DefineFormat
            ' Set the length of list levels to 3 and set their left margins and text formats 
            tocSection.ListFormatArray.Length = 3
            tocSection.ListFormatArray(0).LeftMargin = 0
            tocSection.ListFormatArray(0).TextInfo.FontSize = 16
            tocSection.ListFormatArray(0).TextInfo.IsTrueTypeFontBold = True
            tocSection.ListFormatArray(1).LeftMargin = 16
            tocSection.ListFormatArray(1).TextInfo.FontSize = 14
            tocSection.ListFormatArray(2).LeftMargin = 32
            tocSection.ListFormatArray(2).TextInfo.FontSize = 12
            ' ExEnd:DefineFormat  

            ' Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection)

            dataDir = dataDir & Convert.ToString("DefineFormat_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)

        End Sub
        Public Shared Sub DefineOwnFormat()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a list section 
            Dim tocSection As New Aspose.Pdf.Generator.ListSection("Table Of Contents")

            ' Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents

            ' ExStart:DefineOwnFormat
            ' Define the format of the four levels list by setting the left margins and
            ' Text format settings of each level
            tocSection.ListFormatArray.Length = 4
            tocSection.ListFormatArray(0).LeftMargin = 0
            tocSection.ListFormatArray(0).TextInfo.IsTrueTypeFontBold = True
            tocSection.ListFormatArray(0).TextInfo.IsTrueTypeFontItalic = True
            tocSection.ListFormatArray(1).LeftMargin = 10
            tocSection.ListFormatArray(1).TextInfo.IsUnderline = True
            tocSection.ListFormatArray(1).TextInfo.FontSize = 10
            tocSection.ListFormatArray(2).LeftMargin = 20
            tocSection.ListFormatArray(2).TextInfo.IsTrueTypeFontBold = True
            tocSection.ListFormatArray(3).LeftMargin = 30
            tocSection.ListFormatArray(3).TextInfo.IsTrueTypeFontBold = True
            ' ExEnd:DefineOwnFormat  

            ' Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection)

            dataDir = dataDir & Convert.ToString("DefineOwnFormat_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)

        End Sub

    End Class
End Namespace