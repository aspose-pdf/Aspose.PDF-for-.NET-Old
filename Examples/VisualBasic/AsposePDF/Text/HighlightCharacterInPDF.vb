Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Devices
Imports Aspose.Pdf.Text
Imports System.Drawing

Namespace AsposePDF.Text
    Public Class HighlightCharacterInPDF
        Public Shared Sub Run()
            Try
                ' ExStart:HighlightCharacterInPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

                Dim resolution As Integer = 150

                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

                Using ms As New MemoryStream()
                    Dim conv As New PdfConverter(pdfDocument)
                    conv.Resolution = New Resolution(resolution, resolution)
                    conv.GetNextImage(ms, System.Drawing.Imaging.ImageFormat.Png)

                    Dim bmp As Bitmap = DirectCast(Bitmap.FromStream(ms), Bitmap)

                    Using gr As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
                        Dim scale As Single = resolution / 72.0F
                        gr.Transform = New System.Drawing.Drawing2D.Matrix(scale, 0, 0, -scale, 0, bmp.Height)

                        For i As Integer = 0 To pdfDocument.Pages.Count - 1
                            Dim page As Page = pdfDocument.Pages(1)
                            ' Create TextAbsorber object to find all words
                            Dim textFragmentAbsorber As New TextFragmentAbsorber("[\S]+")
                            textFragmentAbsorber.TextSearchOptions.IsRegularExpressionUsed = True
                            page.Accept(textFragmentAbsorber)
                            ' Get the extracted text fragments
                            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments
                            ' Loop through the fragments
                            For Each textFragment As TextFragment In textFragmentCollection
                                If i = 0 Then
                                    gr.DrawRectangle(Pens.Yellow, CSng(textFragment.Position.XIndent), CSng(textFragment.Position.YIndent), CSng(textFragment.Rectangle.Width), CSng(textFragment.Rectangle.Height))

                                    For segNum As Integer = 1 To textFragment.Segments.Count
                                        Dim segment As TextSegment = textFragment.Segments(segNum)

                                        For charNum As Integer = 1 To segment.Characters.Count
                                            Dim characterInfo As CharInfo = segment.Characters(charNum)

                                            Dim rect As Rectangle = page.GetPageRect(True)
                                            Console.WriteLine("TextFragment = " + textFragment.Text.ToString() + "    Page URY = " + rect.URY.ToString() + "   TextFragment URY = " + textFragment.Rectangle.URY.ToString())

                                            gr.DrawRectangle(Pens.Black, CSng(characterInfo.Rectangle.LLX), CSng(characterInfo.Rectangle.LLY), CSng(characterInfo.Rectangle.Width), CSng(characterInfo.Rectangle.Height))
                                        Next

                                        gr.DrawRectangle(Pens.Green, CSng(segment.Rectangle.LLX), CSng(segment.Rectangle.LLY), CSng(segment.Rectangle.Width), CSng(segment.Rectangle.Height))
                                    Next
                                End If
                            Next
                        Next
                    End Using
                    dataDir = dataDir & Convert.ToString("HighlightCharacterInPDF_out_.png")
                    bmp.Save(dataDir, System.Drawing.Imaging.ImageFormat.Png)
                End Using
                ' ExEnd:HighlightCharacterInPDF            
                Console.WriteLine(Convert.ToString(vbLf & "Characters highlighted successfully in pdf document." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
