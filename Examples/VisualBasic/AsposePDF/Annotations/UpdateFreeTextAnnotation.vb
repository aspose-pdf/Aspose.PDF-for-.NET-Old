Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.Annotations
    Public Class UpdateFreeTextAnnotation
        Public Shared Sub Run()
            Try
                ' ExStart:UpdateFreeTextAnnotation
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

                ' Open document
                Dim doc1 As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Set font size and color of the annotation:
                TryCast(doc1.Pages(1).Annotations(0), FreeTextAnnotation).TextStyle.FontSize = 18
                ' ExEnd:UpdateFreeTextAnnotation
                TryCast(doc1.Pages(1).Annotations(0), FreeTextAnnotation).TextStyle.Color = System.Drawing.Color.Green
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace
