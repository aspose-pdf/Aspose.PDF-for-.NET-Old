Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Generator

Namespace AsposePdfGenerator.UtilityFeatures
    Public Class AddTableOfContents
        Public Shared Sub Run()
            ' ExStart:AddTableOfContents
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Create a PDF instance
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Create a list section 
            Dim tocSection As New Aspose.Pdf.Generator.ListSection("Table Of Contents")
            ' Set its list type as table of contents
            tocSection.ListType = ListType.TableOfContents
            ' Add the list section to the sections collection of the Pdf document
            pdf.Sections.Add(tocSection)

            ' Define the format of the four levels list by setting the left margins and
            ' text format settings of each level
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

            ' Create a section in the Pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Add four headings in the section
            For Level As Integer = 1 To 4
                Dim heading1 As New Aspose.Pdf.Generator.Heading(pdf, sec1, Level)
                Dim segment1 As New Segment(heading1)
                heading1.Segments.Add(segment1)
                heading1.IsAutoSequence = True
                segment1.Content = "this is heading of level "
                segment1.Content += Level.ToString()

                ' Add the heading into Table Of Contents. 
                heading1.IsInList = True
                ' Heading2.TOC = tocSection;
                sec1.Paragraphs.Add(heading1)
            Next

            ' Create a list section 
            Dim tocSection2 As New ListSection("Second Table Of Contents")
            ' Set its list type as table of of contents
            tocSection2.ListType = ListType.TableOfContents
            ' Add the list section to the sections collection of the Pdf document
            pdf.Sections.Add(tocSection2)

            ' Define the format of the four levels list by setting the left margins and
            ' text format settings of each level
            tocSection2.ListFormatArray.Length = 4
            tocSection2.ListFormatArray(0).LeftMargin = 0
            tocSection2.ListFormatArray(0).TextInfo.IsTrueTypeFontBold = True
            tocSection2.ListFormatArray(0).TextInfo.IsTrueTypeFontItalic = True
            tocSection2.ListFormatArray(1).LeftMargin = 10
            tocSection2.ListFormatArray(1).TextInfo.IsUnderline = True
            tocSection2.ListFormatArray(1).TextInfo.FontSize = 10
            tocSection2.ListFormatArray(2).LeftMargin = 20
            tocSection2.ListFormatArray(2).TextInfo.IsTrueTypeFontBold = True
            tocSection2.ListFormatArray(3).LeftMargin = 30
            tocSection2.ListFormatArray(3).TextInfo.IsTrueTypeFontBold = True

            ' Create a section in the Pdf document
            Dim sec2 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Add four headings in the section
            For Level As Integer = 1 To 4
                Dim heading2 As New Aspose.Pdf.Generator.Heading(pdf, sec1, Level)
                Dim segment2 As New Segment(heading2)
                heading2.Segments.Add(segment2)
                heading2.IsAutoSequence = True
                segment2.Content = "this is heading of level "
                segment2.Content += Level.ToString()

                ' Add the heading into Table Of Contents. 
                heading2.IsInList = True
                ' Add the heading elements to second ListSection
                heading2.TOC = tocSection2
                ' Add the heading obejct to paragraphs colelction of section2
                sec2.Paragraphs.Add(heading2)
            Next

            dataDir = dataDir & Convert.ToString("Multiple_TOC_out_.pdf")
            ' Save the resultant PDF document
            pdf.Save(dataDir)
            ' ExEnd:AddTableOfContents           
        End Sub
    End Class
End Namespace