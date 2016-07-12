Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class DeleteParticularAnnotation
        Public Shared Sub Run()
            ' ExStart:DeleteParticularAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteParticularAnnotation.pdf"))

            ' Delete particular annotation
            pdfDocument.Pages(1).Annotations.Delete(1)

            dataDir = dataDir & Convert.ToString("DeleteParticularAnnotation_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteParticularAnnotation
            Console.WriteLine(Convert.ToString(vbLf & "Particular annotation deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
