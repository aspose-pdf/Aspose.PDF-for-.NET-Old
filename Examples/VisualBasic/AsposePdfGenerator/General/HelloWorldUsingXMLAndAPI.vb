Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.General
    Public Class HelloWorldUsingXMLAndAPI
        Public Shared Sub Run()
            Try
                ' ExStart:HelloWorldUsingXMLAndAPI
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_General()

                ' Create pdf document
                Dim pdf1 As New AP.Generator.Pdf()

                ' Instantiate License class and call its SetLicense method to use the license
                Dim license As New AP.License()
                license.SetLicense("Aspose.Pdf.lic")

                ' Bind XML into the document
                pdf1.BindXML(dataDir & Convert.ToString("HelloWorldUsingAPI.XML"), Nothing)

                ' Get the first Section from the PDF document
                Dim sec1 As AP.Generator.Section = pdf1.Sections(0)

                ' Get the Text paragraph (whose ID is Text1) from the section
                Dim text1 As AP.Generator.Text = TryCast(sec1.Paragraphs("Text1"), AP.Generator.Text)

                ' Add a text Segment to the text paragraph
                text1.Segments.Add("Hello World")

                dataDir = dataDir & Convert.ToString("HelloWorldUsingXMLAndAPI_out_.pdf")
                ' Save the document
                ' ExEnd:HelloWorldUsingXMLAndAPI
                pdf1.Save(dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace