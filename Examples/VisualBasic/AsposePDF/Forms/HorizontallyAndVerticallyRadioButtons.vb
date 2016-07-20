Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class HorizontallyAndVerticallyRadioButtons
        Public Shared Sub Run()
            Try
                ' ExStart:HorizontallyAndVerticallyRadioButtons
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Load the previously saved document
                Dim formEditor As New FormEditor()
                formEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))
                ' RadioGap is distance between two radio button options. 
                formEditor.RadioGap = 4
                ' Add horizontal radio button
                formEditor.RadioHoriz = True
                ' RadioButtonItemSize if size of radio button item.
                formEditor.RadioButtonItemSize = 20
                formEditor.Facade.BorderWidth = 1
                formEditor.Facade.BorderColor = System.Drawing.Color.Black
                formEditor.Items = New String() {"First", "Second", "Third"}
                formEditor.AddField(FieldType.Radio, "NewField1", 1, 40, 600, 120, _
                    620)

                ' Add other radio button situated vertically
                formEditor.RadioHoriz = False
                formEditor.Items = New String() {"First", "Second", "Third"}
                formEditor.AddField(FieldType.Radio, "NewField2", 1, 40, 500, 60, _
                    550)


                dataDir = dataDir & Convert.ToString("HorizontallyAndVerticallyRadioButtons_out_.pdf")
                ' Save the PDF document
                formEditor.Save(dataDir)
                ' ExEnd:HorizontallyAndVerticallyRadioButtons
                Console.WriteLine(Convert.ToString(vbLf & "Horizontally and vertically laid out radio buttons successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
