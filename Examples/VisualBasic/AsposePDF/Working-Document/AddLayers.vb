Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose_Pdf = Aspose.Pdf
Imports System.Collections
Imports System.Collections.Generic
Namespace AsposePDF.WorkingDocuments
    Public Class AddLayers
        Public Shared Sub Run()
            ' ExStart:AddLayers
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments
            Dim doc As New Document()
            Dim page As Page = doc.Pages.Add()
            Dim layer As New Layer("oc1", "Red Line")
            layer.Contents.Add(New Aspose_Pdf.Operator.SetRGBColorStroke(1, 0, 0))
            layer.Contents.Add(New Aspose_Pdf.Operator.MoveTo(500, 700))
            layer.Contents.Add(New Aspose_Pdf.Operator.LineTo(400, 700))
            layer.Contents.Add(New Aspose_Pdf.Operator.Stroke())
            page.Layers = New List(Of Layer)()
            page.Layers.Add(layer)
            layer = New Layer("oc2", "Green Line")
            layer.Contents.Add(New Aspose_Pdf.Operator.SetRGBColorStroke(0, 1, 0))
            layer.Contents.Add(New Aspose_Pdf.Operator.MoveTo(500, 750))
            layer.Contents.Add(New Aspose_Pdf.Operator.LineTo(400, 750))
            layer.Contents.Add(New Aspose_Pdf.Operator.Stroke())
            page.Layers.Add(layer)
            layer = New Layer("oc3", "Blue Line")
            layer.Contents.Add(New Aspose_Pdf.Operator.SetRGBColorStroke(0, 0, 1))
            layer.Contents.Add(New Aspose_Pdf.Operator.MoveTo(500, 800))
            layer.Contents.Add(New Aspose_Pdf.Operator.LineTo(400, 800))
            layer.Contents.Add(New Aspose_Pdf.Operator.Stroke())
            page.Layers.Add(layer)
            dataDir = dataDir & Convert.ToString("AddLayers_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:AddLayers
            Console.WriteLine(Convert.ToString(vbLf & "Layers added successfully to PDF file." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
