Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms
Namespace AsposePDF.Forms
    Public Class ComboBox
        Public Shared Sub Run()
            Try
                ' ExStart:ComboBox
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Create Document object
                Dim doc As New Document()

                ' Add page to document object
                doc.Pages.Add()

                ' Instantiate ComboBox Field object
                Dim combo As New ComboBoxField(doc.Pages(1), New Rectangle(100, 600, 150, 616))

                ' Add option to ComboBox
                combo.AddOption("Red")
                combo.AddOption("Yellow")
                combo.AddOption("Green")
                combo.AddOption("Blue")

                ' Add combo box object to form fields collection of document object
                doc.Form.Add(combo)
                dataDir = dataDir & Convert.ToString("ComboBox_out_.pdf")
                ' Save the PDF document
                doc.Save(dataDir)
                ' ExEnd:ComboBox
                Console.WriteLine(Convert.ToString(vbLf & "Combobox field added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
