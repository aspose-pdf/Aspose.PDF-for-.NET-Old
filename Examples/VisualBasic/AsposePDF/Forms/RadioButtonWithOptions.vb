Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text
Namespace AsposePDF.Forms
    Public Class RadioButtonWithOptions
        Public Shared Sub Run()
            Try
                ' ExStart:RadioButtonWithOptions
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                Dim doc As New Document()
                Dim page As Page = doc.Pages.Add()
                Dim table As New Table()
                table.ColumnWidths = "120 120 120"
                page.Paragraphs.Add(table)
                Dim r1 As Row = table.Rows.Add()
                Dim c1 As Cell = r1.Cells.Add()
                Dim c2 As Cell = r1.Cells.Add()
                Dim c3 As Cell = r1.Cells.Add()

                Dim rf As New RadioButtonField(page)
                rf.PartialName = "radio"
                doc.Form.Add(rf, 1)

                Dim opt1 As New RadioButtonOptionField()
                Dim opt2 As New RadioButtonOptionField()
                Dim opt3 As New RadioButtonOptionField()

                opt1.OptionName = "Item1"
                opt2.OptionName = "Item2"
                opt3.OptionName = "Item3"

                opt1.Width = 15
                opt1.Height = 15
                opt2.Width = 15
                opt2.Height = 15
                opt3.Width = 15
                opt3.Height = 15

                rf.Add(opt1)
                rf.Add(opt2)
                rf.Add(opt3)

                opt1.Border = New Border(opt1)
                opt1.Border.Width = 1
                opt1.Border.Style = BorderStyle.Solid
                opt1.Characteristics.Border = System.Drawing.Color.Black
                opt1.DefaultAppearance.TextColor = System.Drawing.Color.Red
                opt1.Caption = New TextFragment("Item1")
                opt2.Border = New Border(opt1)
                opt2.Border.Width = 1
                opt2.Border.Style = BorderStyle.Solid
                opt2.Characteristics.Border = System.Drawing.Color.Black
                opt2.DefaultAppearance.TextColor = System.Drawing.Color.Red
                opt2.Caption = New TextFragment("Item2")
                opt3.Border = New Border(opt1)
                opt3.Border.Width = 1
                opt3.Border.Style = BorderStyle.Solid
                opt3.Characteristics.Border = System.Drawing.Color.Black
                opt3.DefaultAppearance.TextColor = System.Drawing.Color.Red
                opt3.Caption = New TextFragment("Item3")
                c1.Paragraphs.Add(opt1)
                c2.Paragraphs.Add(opt2)
                c3.Paragraphs.Add(opt3)

                dataDir = dataDir & Convert.ToString("RadioButtonWithOptions_out_.pdf")
                ' Save the PDF file
                doc.Save(dataDir)
                ' ExEnd:RadioButtonWithOptions
                Console.WriteLine(Convert.ToString(vbLf & "Radio button field with three options added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace

