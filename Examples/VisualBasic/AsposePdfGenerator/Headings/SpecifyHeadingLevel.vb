Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Headings
    Public Class SpecifyHeadingLevel
        Public Shared Sub Run()
            ' ExStart:SpecifyHeadingLevel
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Headings()
            ' Instntiate the Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create the section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            '
            '             * Create 1st heading in the Pdf object's section with level=1. Then create
            '             * a text segment and add it in the heading. Set its StartNumber=6 to start 
            '             * the numbering from 6 and onwards. And don't forget to set IsAutoSequence=true.
            '             * If IsAutoSeguence property is set to true then the heading's sequence is 
            '             * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
            '             * heading into the paragraphs collection of the section
            '             


            Dim heading1 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 1)
            Dim segment1 As New Aspose.Pdf.Generator.Segment(heading1)
            heading1.Segments.Add(segment1)
            segment1.Content = "Level 1"
            heading1.IsAutoSequence = True
            heading1.StartNumber = 6
            sec1.Paragraphs.Add(heading1)

            '
            '             * Create 2nd heading in the Pdf object's section with level=2. Then create
            '             * a text segment and add it in the heading. And don't forget to set 
            '             * IsAutoSequence=true.If IsAutoSeguence property is set to true then the 
            '             * heading's sequence is controlled automatically by Aspose.Pdf for .NET. After setting
            '             * all properties, add heading into the paragraphs collection of the section
            '             


            Dim heading2 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 2)
            Dim segment2 As New Aspose.Pdf.Generator.Segment(heading2)
            heading2.Segments.Add(segment2)
            segment2.Content = "Level 2"
            heading2.IsAutoSequence = True
            sec1.Paragraphs.Add(heading2)

            '
            '             * Create 3rd heading in the Pdf object's section with level=3. Then create
            '             * a text segment and add it in the heading. And don't forget to set 
            '             * IsAutoSequence=true.If IsAutoSeguence property is set to true then the 
            '             * heading's sequence is controlled automatically by Aspose.Pdf for .NET. After setting
            '             * all properties, add heading into the paragraphs collection of the section
            '             


            Dim heading3 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 3)
            Dim segment3 As New Aspose.Pdf.Generator.Segment(heading3)
            heading3.Segments.Add(segment3)
            segment3.Content = "Level 3"
            heading3.IsAutoSequence = True
            sec1.Paragraphs.Add(heading3)

            pdf1.Save(dataDir & Convert.ToString("SpecifyHeadingLevel_out_.pdf"))
            ' ExEnd:SpecifyHeadingLevel   

        End Sub
    End Class
End Namespace