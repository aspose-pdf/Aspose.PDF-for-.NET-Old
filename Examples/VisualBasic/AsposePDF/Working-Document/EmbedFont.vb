Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class EmbedFont
        Public Shared Sub Run()
            ' ExStart:EmbedFont 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Load an existing PDF files
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Iterate through all the pages
            For Each page As Page In doc.Pages
                If page.Resources.Fonts IsNot Nothing Then
                    For Each pageFont As Font In page.Resources.Fonts
                        ' Check if font is already embedded
                        If Not pageFont.IsEmbedded Then
                            pageFont.IsEmbedded = True
                        End If
                    Next
                End If

                ' Check for the Form objects
                For Each form As XForm In page.Resources.Forms
                    If form.Resources.Fonts IsNot Nothing Then
                        For Each formFont As Font In form.Resources.Fonts
                            ' Check if the font is embedded
                            If Not formFont.IsEmbedded Then
                                formFont.IsEmbedded = True
                            End If
                        Next
                    End If
                Next
            Next
            dataDir = dataDir & Convert.ToString("EmbedFont_out_.pdf")
            ' Save PDF Document
            doc.Save(dataDir)
            ' ExEnd:EmbedFont 
            Console.WriteLine(Convert.ToString(vbLf & "Font embedded successfully in a PDF file." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
