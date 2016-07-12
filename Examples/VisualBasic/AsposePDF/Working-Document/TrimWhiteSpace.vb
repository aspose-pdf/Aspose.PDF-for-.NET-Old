Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Devices
Imports System.Drawing

Namespace AsposePDF.WorkingDocuments
    Public Class TrimWhiteSpace
        Public Shared Sub Run()
            ' ExStart:TrimWhiteSpace
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Load an existing PDF files
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Render the page to image with 72 DPI
            Dim device As New PngDevice(New Resolution(72))

            Using imageStr As New MemoryStream()
                device.Process(doc.Pages(1), imageStr)
                Dim bmp As Bitmap = DirectCast(Bitmap.FromStream(imageStr), Bitmap)

                Dim imageBitmapData As System.Drawing.Imaging.BitmapData = Nothing

                ' Determine white areas
                Try
                    imageBitmapData = bmp.LockBits(New System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.[ReadOnly], System.Drawing.Imaging.PixelFormat.Format32bppRgb)

                    Dim prevCropBox As Rectangle = doc.Pages(1).CropBox

                    Dim toHeight As Integer = bmp.Height
                    Dim toWidth As Integer = bmp.Width

                    Dim leftNonWhite As System.Nullable(Of Integer) = Nothing
                    Dim rightNonWhite As System.Nullable(Of Integer) = Nothing
                    Dim topNonWhite As System.Nullable(Of Integer) = Nothing
                    Dim bottomNonWhite As System.Nullable(Of Integer) = Nothing

                    For y As Integer = 0 To toHeight - 1
                        Dim imageRowBytes As Byte() = New Byte(imageBitmapData.Stride - 1) {}

                        ' Copy the row data to byte array
                        If IntPtr.Size = 4 Then
                            System.Runtime.InteropServices.Marshal.Copy(New IntPtr(imageBitmapData.Scan0.ToInt32() + y * imageBitmapData.Stride), imageRowBytes, 0, imageBitmapData.Stride)
                        Else
                            System.Runtime.InteropServices.Marshal.Copy(New IntPtr(imageBitmapData.Scan0.ToInt64() + y * imageBitmapData.Stride), imageRowBytes, 0, imageBitmapData.Stride)
                        End If


                        Dim leftNonWhite_row As System.Nullable(Of Integer) = Nothing
                        Dim rightNonWhite_row As System.Nullable(Of Integer) = Nothing

                        For x As Integer = 0 To toWidth - 1
                            If imageRowBytes(x * 4) <> 255 OrElse imageRowBytes(x * 4 + 1) <> 255 OrElse imageRowBytes(x * 4 + 2) <> 255 Then
                                If leftNonWhite_row Is Nothing Then
                                    leftNonWhite_row = x
                                End If

                                rightNonWhite_row = x
                            End If
                        Next

                        If leftNonWhite_row IsNot Nothing OrElse rightNonWhite_row IsNot Nothing Then
                            If topNonWhite Is Nothing Then
                                topNonWhite = y
                            End If

                            bottomNonWhite = y
                        End If

                        If leftNonWhite_row IsNot Nothing AndAlso (leftNonWhite Is Nothing OrElse leftNonWhite > leftNonWhite_row) Then
                            leftNonWhite = leftNonWhite_row
                        End If
                        If rightNonWhite_row IsNot Nothing AndAlso (rightNonWhite Is Nothing OrElse rightNonWhite < rightNonWhite_row) Then
                            rightNonWhite = rightNonWhite_row
                        End If
                    Next

                    leftNonWhite = If(leftNonWhite, 0)
                    rightNonWhite = If(rightNonWhite, toWidth)
                    topNonWhite = If(topNonWhite, 0)
                    bottomNonWhite = If(bottomNonWhite, toHeight)

                    ' Set crop box with correction to previous crop box
                    doc.Pages(1).CropBox = New Rectangle(leftNonWhite.Value + prevCropBox.LLX, (toHeight + prevCropBox.LLY) - bottomNonWhite.Value, rightNonWhite.Value + doc.Pages(1).CropBox.LLX, (toHeight + prevCropBox.LLY) - topNonWhite.Value)
                Finally
                    If imageBitmapData IsNot Nothing Then
                        bmp.UnlockBits(imageBitmapData)
                    End If
                End Try
            End Using
            dataDir = dataDir & Convert.ToString("TrimWhiteSpace_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:TrimWhiteSpace
            Console.WriteLine(Convert.ToString(vbLf & "White-space trimmed successfully around a page." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace