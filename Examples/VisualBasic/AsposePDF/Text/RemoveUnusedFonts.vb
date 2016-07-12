Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Namespace AsposePDF.Text
    Public Class RemoveUnusedFonts
        Public Shared Sub Run()
            Try
                ' ExStart:RemoveUnusedFonts
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

                ' Load source PDF file
                Dim doc As New Document(dataDir & Convert.ToString("ReplaceTextPage.pdf"))
                Dim absorber As New TextFragmentAbsorber(New TextEditOptions(TextEditOptions.FontReplace.RemoveUnusedFonts))
                doc.Pages.Accept(absorber)

                ' Iterate through all the TextFragments
                For Each textFragment As TextFragment In absorber.TextFragments
                    textFragment.TextState.Font = FontRepository.FindFont("Arial, Bold")
                Next

                dataDir = dataDir & Convert.ToString("RemoveUnusedFonts_out_.pdf")
                ' Save updated document
                doc.Save(dataDir)
                ' ExEnd:RemoveUnusedFonts            
                Console.WriteLine(Convert.ToString(vbLf & "Unused fonts removed successfully from pdf document." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
