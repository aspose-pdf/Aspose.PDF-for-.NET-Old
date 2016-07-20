Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports System.Collections

Namespace AsposePDF.Annotations
    Public Class AddlnkAnnotation
        Public Shared Sub Run()
            ' ExStart:AddlnkAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            Dim doc As New Document()
            Dim pdfPage As Page = doc.Pages.Add()
            Dim drect As New System.Drawing.Rectangle()
            drect.Height = CInt(pdfPage.Rect.Height)
            drect.Width = CInt(pdfPage.Rect.Width)
            drect.X = 0
            drect.Y = 0
            Dim arect As Rectangle = Rectangle.FromRect(drect)
            Dim inkList As New ArrayList()
            Dim arrpt As Point() = New Point(2) {}
            inkList.Add(arrpt)
            arrpt(0) = New Point(100, 800)
            arrpt(1) = New Point(200, 800)
            arrpt(2) = New Point(200, 700)
            Dim ia As New InkAnnotation(pdfPage, arect, inkList)
            ia.Title = "XXX"
            ia.Color = Color.LightBlue
            ' (GetColorFromString(stroke.InkColor));
            ia.CapStyle = CapStyle.Rounded
            Dim border As New Border(ia)
            border.Width = 25
            ia.Opacity = 0.5
            pdfPage.Annotations.Add(ia)

            dataDir = dataDir & Convert.ToString("AddlnkAnnotation_out_.pdf")
            ' Save output file
            doc.Save(dataDir)
            ' ExEnd:AddlnkAnnotation
            Console.WriteLine(Convert.ToString(vbLf & "lnk annotation added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

