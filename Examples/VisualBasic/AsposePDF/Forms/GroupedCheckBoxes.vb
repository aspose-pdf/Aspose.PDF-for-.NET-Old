Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Forms
Namespace AsposePDF.Forms
    Public Class GroupedCheckBoxes
        Public Shared Sub Run()
            Try
                ' ExStart:GroupedCheckBoxes
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Instantiate Document object
                Dim pdfDocument As New Document()
                ' Add a page to PDF file
                Dim page As Page = pdfDocument.Pages.Add()
                ' Instatiate RadioButtonField object with page number as argument
                Dim radio As New RadioButtonField(pdfDocument.Pages(1))
                ' Add first radio button option and also specify its origin using Rectangle object
                Dim opt1 As New RadioButtonOptionField(page, New Rectangle(0, 0, 20, 20))
                Dim opt2 As New RadioButtonOptionField(page, New Rectangle(100, 0, 120, 20))
                opt1.OptionName = "Test1"
                opt2.OptionName = "Test2"

                radio.Add(opt1)
                radio.Add(opt2)
                opt1.Style = BoxStyle.Square
                opt2.Style = BoxStyle.Square
                opt1.Style = BoxStyle.Cross
                opt2.Style = BoxStyle.Cross
                opt1.Border = New Border(opt1)
                opt1.Border.Style = BorderStyle.Solid
                opt1.Border.Width = 1
                opt1.Characteristics.Border = System.Drawing.Color.Black
                opt2.Border = New Border(opt2)
                opt2.Border.Width = 1

                opt2.Border.Style = BorderStyle.Solid
                opt2.Characteristics.Border = System.Drawing.Color.Black

                ' Add radio button to form object of Document object
                pdfDocument.Form.Add(radio)

                dataDir = dataDir & Convert.ToString("GroupedCheckBoxes_out_.pdf")
                ' Save the PDF document
                pdfDocument.Save(dataDir)
                ' ExEnd:GroupedCheckBoxes
                Console.WriteLine(Convert.ToString(vbLf & "Grouped checkboxes added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
