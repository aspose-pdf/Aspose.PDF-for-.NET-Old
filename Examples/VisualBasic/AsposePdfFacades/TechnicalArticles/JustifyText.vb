Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class JustifyText
        Public Shared Sub Run()
            ' ExStart:JustifyText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            Using source As FileStream = File.Open(dataDir & Convert.ToString("Input1.pdf"), FileMode.Open)
                Dim ms As New MemoryStream()

                ' Create Form Object
                Dim form As New Aspose.Pdf.Facades.Form()

                ' Open Source File
                form.BindPdf(source)

                ' Fill Text Field
                form.FillField("Text1", "Thank you for using Aspose")

                ' Save the document in Memory Stream
                form.Save(ms)

                ms.Seek(0, SeekOrigin.Begin)

                Dim dest As New FileStream(dataDir & Convert.ToString("JustifyText_out_.pdf"), FileMode.Create)

                ' Create formEditor Object
                Dim formEditor As New FormEditor()

                ' Open PDF from memory stream
                formEditor.BindPdf(ms)

                ' Set Text Alignment as Justified
                formEditor.Facade.Alignment = FormFieldFacade.AlignJustified

                ' Decorate form field.
                formEditor.DecorateField()

                ' Save te resultant file.
                formEditor.Save(dest)

                ' Close file stream
                dest.Close()
            End Using
            ' ExEnd:JustifyText                      
        End Sub
    End Class
End Namespace
