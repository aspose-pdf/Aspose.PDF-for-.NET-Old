Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class CreateDoc
        Public Shared Sub Run()
            Try
                ' ExStart:CreateDoc
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Create a new document
                Dim doc As New Document()
                Dim page As Page = doc.Pages.Add()
                ' Add radio button field
                Dim field As New RadioButtonField(page)
                field.Rect = New Rectangle(40, 650, 100, 720)
                field.PartialName = "NewField"

                ' Add radio button options. please note that these options are situated 
                ' neither horizontally nor vertically. 
                ' You can try to set any coordinates (and even size) for them. 
                Dim opt1 As New RadioButtonOptionField()
                opt1.Rect = New Rectangle(40, 650, 60, 670)
                opt1.OptionName = "Item1"
                opt1.Border = New Border(opt1)
                opt1.Border.Width = 1
                opt1.Characteristics.Border = System.Drawing.Color.Black

                Dim opt2 As New RadioButtonOptionField()
                opt2.Rect = New Rectangle(60, 670, 80, 690)
                opt2.OptionName = "Item2"
                opt2.Border = New Border(opt2)
                opt2.Border.Width = 1
                opt2.Characteristics.Border = System.Drawing.Color.Black

                Dim opt3 As New RadioButtonOptionField()
                opt3.Rect = New Rectangle(80, 690, 100, 710)
                opt3.OptionName = "Item3"
                opt3.Border = New Border(opt3)
                opt3.Border.Width = 1
                opt3.Characteristics.Border = System.Drawing.Color.Black
                field.Add(opt1)
                field.Add(opt2)
                field.Add(opt3)
                doc.Form.Add(field)

                dataDir = dataDir & Convert.ToString("CreateDoc_out_.pdf")
                ' Save the PDF document
                doc.Save(dataDir)
                ' ExEnd:CreateDoc
                Console.WriteLine(Convert.ToString(vbLf & "New doc with 3 items radio button created successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
