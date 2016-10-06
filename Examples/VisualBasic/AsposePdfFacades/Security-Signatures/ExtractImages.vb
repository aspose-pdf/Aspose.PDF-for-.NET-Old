Imports System.IO
Imports System
Imports System.Drawing.Imaging
Imports System.Drawing
Imports Aspose.Pdf.Facades
Imports System.Collections

Namespace AsposePDFFacades.SecuritySignatures
    Public Class ExtractImages
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractImages               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                Dim input As String = dataDir & Convert.ToString("DigitallySign.pdf")
                Dim doc As New Document(input)
                Using signature As New PdfFileSignature(doc)
                    If signature.ContainsSignature() Then
                        For Each sigName As String In signature.GetSignNames()
                            Dim outFile As String = dataDir & Convert.ToString("ExtractImages_out_.jpg")
                            Using imageStream As Stream = signature.ExtractImage(sigName)
                                If imageStream IsNot Nothing Then
                                    Using image As System.Drawing.Image = Bitmap.FromStream(imageStream)
                                        image.Save(outFile, ImageFormat.Jpeg)
                                    End Using
                                End If
                            End Using
                        Next
                    End If
                    ' ExEnd:ExtractImages
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
