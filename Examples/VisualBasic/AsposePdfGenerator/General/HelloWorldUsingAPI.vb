Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.General
    Public Class HelloWorldUsingAPI
        Public Shared Sub Run()
            Try
                ' ExStart:HelloWorldUsingAPI
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_General()

                ' Create pdf document
                Dim pdf1 As New AP.Generator.Pdf()

                ' Instantiate License class and call its SetLicense method to use the license
                Dim license As New AP.License()
                license.SetLicense("Aspose.Pdf.lic")

                ' Add a section into the pdf document
                Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

                ' Add a text paragraph into the section
                sec1.Paragraphs.Add(New AP.Generator.Text("Hello World"))

                dataDir = dataDir & Convert.ToString("HelloWorldUsingAPI_out_.pdf")
                ' Save the document
                pdf1.Save(dataDir)
                ' ExEnd:HelloWorldUsingAPI
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace