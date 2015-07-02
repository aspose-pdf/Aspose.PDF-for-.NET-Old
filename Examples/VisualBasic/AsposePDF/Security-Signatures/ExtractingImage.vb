'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports System.Drawing

Namespace VisualBasic.AsposePdf.SecuritySignatures
    Public Class ExtractingImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

            Dim input As String = dataDir & "ExtractingImage.pdf"
            Using pdfDocument As New Document(input)
                For Each field As Field In pdfDocument.Form
                    Dim sf As SignatureField = TryCast(field, SignatureField)
                    If sf IsNot Nothing Then
                        Dim outFile As String = dataDir & "output.jpg"
                        Using imageStream As Stream = sf.ExtractImage()
                            If imageStream IsNot Nothing Then
                                Using image As System.Drawing.Image = Bitmap.FromStream(imageStream)
                                    image.Save(outFile, System.Drawing.Imaging.ImageFormat.Jpeg)
                                End Using
                            End If
                        End Using
                    End If
                Next field
            End Using


        End Sub
    End Class
End Namespace