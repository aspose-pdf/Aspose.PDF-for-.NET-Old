Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class HyphenationWhileCreatingPDF
        Public Shared Sub Run()
            Try
                ' ExStart:HyphenationWhileCreatingPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

                ' Create pdf document
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Instantiate License class and call its SetLicense method to use the license
                Dim license As New Aspose.Pdf.License()
                license.SetLicense("Aspose.Pdf.lic")

                ' Bind XML into the document
                pdf1.BindXML(dataDir & Convert.ToString("Hyphen-test.xml"), Nothing)

                ' Enable hyphenation function. Default value is false.
                pdf1.IsAutoHyphenated = True

                ' Set the hyphenation dictionary path.
                pdf1.HyphenationDictionaryPath = dataDir & Convert.ToString("Hyphen.xml")

                ' Set the hyphenation area width. Default value is 12 points.
                pdf1.HyphenationZoneWidth = 0

                ' Set the maximum number of consecutive hyphenations. Default value is zero that means no //limits.
                pdf1.ConsecutiveHyphensLimits = 0

                ' Save the Pdf file
                ' ExEnd:HyphenationWhileCreatingPDF     
                pdf1.Save(dataDir & Convert.ToString("Hyphen-test_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
