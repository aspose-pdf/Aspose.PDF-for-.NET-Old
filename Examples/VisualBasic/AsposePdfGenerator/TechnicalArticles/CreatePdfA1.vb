Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Microsoft.VisualBasic

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class CreatePdfA1
        Public Shared Sub Run()
            Try
                ' ExStart:CreatePdfA1
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

                ' Create pdf document
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Instantiate License class and call its SetLicense method to use the license
                Dim license As New Aspose.Pdf.License()
                license.SetLicense("Aspose.Custom.lic")

                ' Set the conformance property of Pdf class to predefined value
                pdf1.Conformance = Aspose.Pdf.Generator.PdfConformance.PdfA1B

                ' Add a section into the pdf document
                Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

                'Save the document
                ' ExEnd:CreatePdfA1  
                pdf1.Save(dataDir & Convert.ToString("CreatePdfA1_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
