Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Drawing
Namespace AsposePDF.Text
    Public Class CreateMultiColumnPdf
        Public Shared Sub Run()
            ' ExStart:CreateMultiColumnPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim doc As New Document()
            ' Specify the left margin info for the PDF file
            doc.PageInfo.Margin.Left = 40
            ' Specify the Right margin info for the PDF file
            doc.PageInfo.Margin.Right = 40
            Dim page As Page = doc.Pages.Add()

            Dim graph1 As New Graph(500, 2)
            ' Add the line to paraphraphs collection of section object
            page.Paragraphs.Add(graph1)

            ' Specify the coordinates for the line
            Dim posArr As Single() = New Single() {1, 2, 500, 2}
            Dim l1 As New Line(posArr)
            graph1.Shapes.Add(l1)
            ' Create string variables with text containing html tags


            Dim s As String = "<font face=""Times New Roman"" size=4>" + "<strong> How to Steer Clear of money scams</<strong> " + "</font>"
            ' Create text paragraphs containing HTML text

            Dim heading_text As New HtmlFragment(s)
            page.Paragraphs.Add(heading_text)

            Dim box As New FloatingBox()
            ' Add four columns in the section
            box.ColumnInfo.ColumnCount = 2
            ' Set the spacing between the columns
            box.ColumnInfo.ColumnSpacing = "5"

            box.ColumnInfo.ColumnWidths = "105 105"
            Dim text1 As New TextFragment("By A Googler (The Official Google Blog)")
            text1.TextState.FontSize = 8
            text1.TextState.LineSpacing = 2
            box.Paragraphs.Add(text1)
            text1.TextState.FontSize = 10

            text1.TextState.FontStyle = FontStyles.Italic
            ' Create a graphs object to draw a line
            Dim graph2 As New Graph(50, 10)
            ' Specify the coordinates for the line
            Dim posArr2 As Single() = New Single() {1, 10, 100, 10}
            Dim l2 As New Line(posArr2)
            graph2.Shapes.Add(l2)

            ' Add the line to paragraphs collection of section object
            box.Paragraphs.Add(graph2)

            Dim text2 As New TextFragment("Sed augue tortor, sodales id, luctus et, pulvinar ut, eros. Suspendisse vel dolor. Sed quam. Curabitur ut massa vitae eros euismod aliquam. Pellentesque sit amet elit. Vestibulum interdum pellentesque augue. Cras mollis arcu sit amet purus. Donec augue. Nam mollis tortor a elit. Nulla viverra nisl vel mauris. Vivamus sapien. nascetur ridiculus mus. Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et,nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et, semper sed, enim nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed urna. . Duis convallis ultrices nisi. Maecenas non ligula. Nunc nibh est, tincidunt in, placerat sit amet, vestibulum a, nulla. Praesent porttitor turpis eleifend ante. Morbi sodales.nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed urna. . Duis convallis ultrices nisi. Maecenas non ligula. Nunc nibh est, tincidunt in, placerat sit amet, vestibulum a, nulla. Praesent porttitor turpis eleifend ante. Morbi sodales.")
            box.Paragraphs.Add(text2)

            page.Paragraphs.Add(box)

            dataDir = dataDir & Convert.ToString("CreateMultiColumnPdf_out_.pdf")
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:CreateMultiColumnPdf            
            Console.WriteLine(Convert.ToString(vbLf & "Multi column pdf file created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace