Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Miscellaneous
    Public Class ReadMeasure
        Public Shared Sub Run()
            Try
                ' ExStart:ReadMeasure
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Miscellaneous()

                Dim doc As New Document(dataDir & Convert.ToString("ReadMeasure.pdf"))
                Console.WriteLine(TryCast(doc.Pages(1).Annotations(1), LineAnnotation).Measure.ScaleRatio)
                Console.WriteLine(TryCast(doc.Pages(1).Annotations(1), LineAnnotation).Measure.AreaFormat(1).UnitLabel)
                Console.WriteLine(TryCast(doc.Pages(1).Annotations(1), LineAnnotation).Measure.AreaFormat(1).ConvresionFactor)

                Console.WriteLine(TryCast(doc.Pages(1).Annotations(1), LineAnnotation).Measure.AreaFormat(1).FractionSeparator)
                ' ExEnd:ReadMeasure
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace