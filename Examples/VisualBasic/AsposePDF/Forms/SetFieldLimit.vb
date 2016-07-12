Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports APF = Aspose.Pdf.Facades
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class SetFieldLimit
        Public Shared Sub Run()
            ' ExStart:SetFieldLimit
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Adding Field with limit
            Dim form As New APF.FormEditor()

            form.BindPdf(dataDir & Convert.ToString("input.pdf"))
            form.SetFieldLimit("textbox1", 15)
            dataDir = dataDir & Convert.ToString("SetFieldLimit_out_.pdf")
            form.Save(dataDir)
            ' ExEnd:SetFieldLimit
            Console.WriteLine(Convert.ToString(vbLf & "Field added successfully with limit." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub GetMaxFieldLimit()
            ' ExStart:GetMaxFieldLimit
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()
            ' Getting maximum field limit using DOM
            Dim doc As New Document(dataDir & Convert.ToString("FieldLimit.pdf"))
            Console.WriteLine("Limit: " + TryCast(doc.Form("textbox1"), TextBoxField).MaxLen.ToString())
            ' ExEnd:GetMaxFieldLimit
        End Sub
        Public Shared Sub GetMaxFieldLimitUsingFacades()
            ' ExStart:GetMaxFieldLimitUsingFacades
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()
            ' Getting maximum field limit using Facades
            Dim form As New APF.Form()
            form.BindPdf(dataDir & Convert.ToString("FieldLimit.pdf"))
            Console.WriteLine("Limit: " + form.GetFieldLimit("textbox1").ToString())
            ' ExEnd:GetMaxFieldLimitUsingFacades
        End Sub
    End Class
End Namespace
