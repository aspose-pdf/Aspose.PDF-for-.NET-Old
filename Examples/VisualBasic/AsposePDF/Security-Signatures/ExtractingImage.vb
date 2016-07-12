Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms
Imports System.Drawing

Namespace AsposePDF.SecuritySignatures
    Public Class ExtractingImage
        Public Shared Sub Run()
            ' ExStart:ExtractingImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

            Dim input As String = dataDir & Convert.ToString("ExtractingImage.pdf")
            Using pdfDocument As New Document(input)
                For Each field As Field In pdfDocument.Form
                    Dim sf As SignatureField = TryCast(field, SignatureField)
                    If sf IsNot Nothing Then
                        Dim outFile As String = dataDir & Convert.ToString("output_out_.jpg")
                        Using imageStream As Stream = sf.ExtractImage()
                            If imageStream IsNot Nothing Then
                                Using image As System.Drawing.Image = Bitmap.FromStream(imageStream)
                                    image.Save(outFile, System.Drawing.Imaging.ImageFormat.Jpeg)
                                End Using
                            End If
                        End Using
                    End If
                Next
            End Using
            ' ExEnd:ExtractingImage
        End Sub
    End Class
End Namespace
