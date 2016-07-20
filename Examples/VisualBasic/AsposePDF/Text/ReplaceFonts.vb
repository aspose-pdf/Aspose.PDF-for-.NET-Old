Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions

Namespace AsposePDF.Text
    Public Class ReplaceFonts
        Public Shared Sub Run()
            Try
                ' ExStart:ReplaceFonts
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

                ' Load source PDF file
                Dim pdfDocument As New Document(dataDir & Convert.ToString("ReplaceTextPage.pdf"))
                ' Search text fragments and set edit option as remove unused fonts
                Dim absorber As New TextFragmentAbsorber(New TextEditOptions(TextEditOptions.FontReplace.RemoveUnusedFonts))

                ' Accept the absorber for all the pages
                pdfDocument.Pages.Accept(absorber)
                ' Traverse through all the TextFragments
                For Each textFragment As TextFragment In absorber.TextFragments
                    ' If the font name is ArialMT, replace font name with Arial
                    If textFragment.TextState.Font.FontName = "Arial,Bold" Then
                        textFragment.TextState.Font = FontRepository.FindFont("Arial")

                    End If
                Next

                dataDir = dataDir & Convert.ToString("ReplaceFonts_out_.pdf")
                ' Save updated document
                pdfDocument.Save(dataDir)
                ' ExEnd:ReplaceFonts            
                Console.WriteLine(Convert.ToString(vbLf & "Fonts replaced successfully in pdf document." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace