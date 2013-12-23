'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace GetSVGDimensions
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim loadopt = New SvgLoadOptions()
			loadopt.AdjustPageSize = True
			Dim svgDoc = New Document(dataDir & "Example.svg", loadopt)
			svgDoc.Pages(1).PageInfo.Margin.Top = 0
			svgDoc.Pages(1).PageInfo.Margin.Left = 0
			svgDoc.Pages(1).PageInfo.Margin.Bottom = 0
			svgDoc.Pages(1).PageInfo.Margin.Right = 0
			svgDoc.Save(dataDir & "SVG_test.pdf")
		End Sub
	End Class
End Namespace