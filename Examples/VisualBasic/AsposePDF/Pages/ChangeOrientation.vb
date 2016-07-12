Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class ChangeOrientation
        Public Shared Sub Run()
            ' ExStart:ChangeOrientation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            Dim doc As New Document(dataDir & "input.pdf")
            For Each page As Page In doc.Pages
                Dim r As Rectangle = page.MediaBox
                Dim newHeight As Double = r.Width
                Dim newWidth As Double = r.Height
                Dim newLLX As Double = r.LLX
                '  We must to move page upper in order to compensate changing page size
                ' (lower edge of the page is 0,0 and information is usually placed from the
                '  Top of the page. That's why we move lover edge upper on difference between
                '  Old and new height.
                Dim newLLY As Double = r.LLY + (r.Height - newHeight)
                page.MediaBox = New Rectangle(newLLX, newLLY, newLLX + newWidth, newLLY + newHeight)
                ' Sometimes we also need to set CropBox (if it was set in original file)
                page.CropBox = New Rectangle(newLLX, newLLY, newLLX + newWidth, newLLY + newHeight)

                ' Setting Rotation angle of page
                page.Rotate = Rotation.on90
            Next

            dataDir = dataDir & "ChangeOrientation_out_.pdf"
            ' Save output file
            doc.Save(dataDir)
            ' ExEnd:ChangeOrientation
            System.Console.WriteLine(Convert.ToString(vbLf & "Page orientation changed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
