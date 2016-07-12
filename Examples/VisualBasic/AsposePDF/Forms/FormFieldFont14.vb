Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Forms
    Public Class FormFieldFont14
        Public Shared Sub Run()
            ' ExStart:FormFieldFont14
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("FormFieldFont14.pdf"))

            ' Get particular form field from document
            Dim field As Field = TryCast(pdfDocument.Form("textbox1"), Field)

            ' Create font object
            Dim font As Font = FontRepository.FindFont("ComicSansMS")

            ' Set the font information for form field
            ' Field.DefaultAppearance = new Aspose.Pdf.Forms.in.DefaultAppearance(font, 10, System.Drawing.Color.Black);

            dataDir = dataDir & Convert.ToString("FormFieldFont14_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:FormFieldFont14
            Console.WriteLine(Convert.ToString(vbLf & "Form field font setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
