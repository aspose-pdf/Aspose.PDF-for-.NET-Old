Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Namespace AsposePDF.Forms
    Public Class RadioButton
        Public Shared Sub Run()
            Try
                ' ExStart:RadioButton
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Instantiate Document object
                Dim pdfDocument As New Document()
                ' Add a page to PDF file
                pdfDocument.Pages.Add()
                ' Instatiate RadioButtonField object with page number as argument
                Dim radio As New RadioButtonField(pdfDocument.Pages(1))
                ' Add first radio button option and also specify its origin using Rectangle object
                radio.AddOption("Test", New Rectangle(0, 0, 20, 20))
                ' Add second radio button option
                radio.AddOption("Test1", New Rectangle(20, 20, 40, 40))
                ' Add radio button to form object of Document object
                pdfDocument.Form.Add(radio)

                dataDir = dataDir & Convert.ToString("RadioButton_out_.pdf")
                ' Save the PDF file
                pdfDocument.Save(dataDir)
                ' ExEnd:RadioButton
                Console.WriteLine(Convert.ToString(vbLf & "Radio button field added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace
