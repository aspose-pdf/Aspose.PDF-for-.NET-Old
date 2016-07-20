Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions

Namespace AsposePDF.Text
    Public Class RearrangeContentsUsingTextReplacement
        Public Shared Sub Run()
            Try
                ' ExStart:RearrangeContentsUsingTextReplacement
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

                ' Load source PDF file
                Dim doc As New Document(dataDir & Convert.ToString("ExtractTextPage.pdf"))
                ' Create TextFragment Absorber object with regular expression
                Dim textFragmentAbsorber As New TextFragmentAbsorber("[TextFragmentAbsorber,companyname,Textbox,50]")
                doc.Pages.Accept(textFragmentAbsorber)
                ' Replace each TextFragment
                For Each textFragment As TextFragment In textFragmentAbsorber.TextFragments
                    ' Set font of text fragment being replaced
                    textFragment.TextState.Font = FontRepository.FindFont("Arial")
                    ' Set font size
                    textFragment.TextState.FontSize = 12
                    textFragment.TextState.ForegroundColor = Color.Navy
                    ' Replace the text with larger string than placeholder
                    textFragment.Text = "This is a Larger String for the Testing of this issue"
                Next
                dataDir = dataDir & Convert.ToString("RearrangeContentsUsingTextReplacement_out_.pdf")
                ' Save resultant PDF
                doc.Save(dataDir)
                ' ExEnd:RearrangeContentsUsingTextReplacement            
                Console.WriteLine(Convert.ToString(vbLf & "Contents rearranged successfully using text replacement." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
