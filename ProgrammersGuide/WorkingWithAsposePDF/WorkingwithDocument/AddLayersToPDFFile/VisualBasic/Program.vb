'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports System.Collections

Namespace AddLayersToPDFFileExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim doc As New Document()
			Dim page As Page = doc.Pages.Add()
			Dim layer As New Layer("oc1", "Red Line")
			layer.Contents.Add(New Operator.SetRGBColorStroke(1, 0, 0))
			layer.Contents.Add(New Operator.MoveTo(500, 700))
			layer.Contents.Add(New Operator.LineTo(400, 700))
			layer.Contents.Add(New Operator.Stroke())
			page.Layers = New ArrayList()
			page.Layers.Add(layer)
			layer = New Layer("oc2", "Green Line")
			layer.Contents.Add(New Operator.SetRGBColorStroke(0, 1, 0))
			layer.Contents.Add(New Operator.MoveTo(500, 750))
			layer.Contents.Add(New Operator.LineTo(400, 750))
			layer.Contents.Add(New Operator.Stroke())
			page.Layers.Add(layer)
			layer = New Layer("oc3", "Blue Line")
			layer.Contents.Add(New Operator.SetRGBColorStroke(0, 0, 1))
			layer.Contents.Add(New Operator.MoveTo(500, 800))
			layer.Contents.Add(New Operator.LineTo(400, 800))
			layer.Contents.Add(New Operator.Stroke())
			page.Layers.Add(layer)
			doc.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace