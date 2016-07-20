Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports AP = Aspose.Pdf
Imports System.Collections

Namespace AsposePDF.Operators
    Public Class RemoveGraphicsObjects
        Public Shared Sub Run()
            ' ExStart:RemoveGraphicsObjects
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Operators()

            Dim doc As New Document(dataDir & Convert.ToString("RemoveGraphicsObjects.pdf"))
            Dim page As Page = doc.Pages(2)
            Dim oc As OperatorCollection = page.Contents

            ' Used path-painting operators
            Dim opera As [Operator]() = New [Operator]() {New AP.Operator.Stroke(), New AP.Operator.ClosePathStroke(), New AP.Operator.Fill()}

            Dim list As New ArrayList()
            For Each op As [Operator] In opera
                Dim os As New OperatorSelector(op)
                oc.Accept(os)
                list.AddRange(os.Selected)
            Next

            oc.Delete(list)
            doc.Save(dataDir & Convert.ToString("No_Graphics_out_.pdf"))
            ' ExEnd:RemoveGraphicsObjects
        End Sub
    End Class
End Namespace