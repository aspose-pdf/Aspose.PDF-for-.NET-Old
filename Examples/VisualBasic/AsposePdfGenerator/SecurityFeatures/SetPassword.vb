Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.SecurityFeatures
    Public Class SetPassword
        Public Shared Sub Run()
            ' ExStart:SetPassword
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_SecurityFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Assign a security instance to Pdf object
            pdf1.Security = New Aspose.Pdf.Generator.Security()

            ' Set the master password for the PDF document
            pdf1.Security.MasterPassword = "master"

            ' Set the user password for the PDF document
            pdf1.Security.UserPassword = "user"

            ' Add a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "this is text content")

            ' Set the top maring of text paragraph to 30
            text1.Margin.Top = 30

            ' Add the text paragraph to the section
            sec1.Paragraphs.Add(text1)
            dataDir = dataDir & Convert.ToString("SetPassword_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:SetPassword           
        End Sub
    End Class
End Namespace
