Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class InvisibleAnnotation
        Public Shared Sub Run()
            ' ExStart:InvisibleAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            Dim annotation As New FreeTextAnnotation(doc.Pages(1), New Rectangle(50, 600, 250, 650), New DefaultAppearance("Helvetica", 16, System.Drawing.Color.Red))
            annotation.Contents = "ABCDEFG"
            annotation.Characteristics.Border = System.Drawing.Color.Red
            annotation.Flags = AnnotationFlags.Print Or AnnotationFlags.NoView
            doc.Pages(1).Annotations.Add(annotation)

            dataDir = dataDir & Convert.ToString("InvisibleAnnotation_out_.pdf")
            ' Save output file
            doc.Save(dataDir)
            ' ExEnd:InvisibleAnnotation
            Console.WriteLine(Convert.ToString(vbLf & "Annotation nvisible successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
