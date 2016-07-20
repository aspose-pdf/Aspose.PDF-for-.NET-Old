Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class DecorateParticularField
        Public Shared Sub Run()
            ' ExStart:DecorateParticularField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Set field facade
            Dim fieldFacade As New FormFieldFacade()
            form.Facade = fieldFacade
            fieldFacade.BackgroundColor = System.Drawing.Color.Red
            fieldFacade.FontSize = 14
            ' Specify the form field which needs to be decorated
            form.DecorateField("textfield")
            ' Save updated PDF form
            form.Save(dataDir & Convert.ToString("DecorateParticularField_out_.pdf"))
            ' ExEnd:DecorateParticularField
        End Sub
        Public Shared Sub SetFont()
            ' ExStart:SetFont
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New FormEditor()
            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Set field facade
            Dim fieldFacade As New FormFieldFacade()
            form.Facade = fieldFacade
            fieldFacade.BackgroundColor = System.Drawing.Color.Red
            fieldFacade.FontSize = 14
            ' Set font for form field
            fieldFacade.CustomFont = "CourierNew"
            ' Specify the form field which needs to be decorated
            form.DecorateField("textfield")
            ' Save updated PDF form
            form.Save("SetFont_out_.pdf")
            ' ExEnd:SetFont
        End Sub
    End Class
End Namespace
