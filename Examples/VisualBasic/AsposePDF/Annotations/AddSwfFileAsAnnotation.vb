Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class AddSwfFileAsAnnotation
        Public Shared Sub Run()
            ' ExStart:AddSwfFileAsAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open the PDF document
            Dim doc As New Document(dataDir & Convert.ToString("AddSwfFileAsAnnotation.pdf"))

            ' Get reference of the page to which you need to add the annotation
            Dim page As Page = doc.Pages(1)

            ' Create ScreenAnnotation object with .swf multimedia file as an argument
            Dim annotation As New ScreenAnnotation(page, New Rectangle(0, 400, 600, 700), dataDir & Convert.ToString("input.swf"))

            ' Add the annotation to annotations collection of page
            page.Annotations.Add(annotation)

            dataDir = dataDir & Convert.ToString("AddSwfFileAsAnnotation_out_.pdf")
            ' Save the update PDF document with annotation
            doc.Save(dataDir)
            ' ExEnd:AddSwfFileAsAnnotation
            Console.WriteLine(Convert.ToString(vbLf & "SWF file annotation added to pdf document." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
