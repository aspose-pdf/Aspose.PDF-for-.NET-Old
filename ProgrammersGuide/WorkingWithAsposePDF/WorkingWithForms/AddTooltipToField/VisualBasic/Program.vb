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
Imports Aspose.Pdf.InteractiveFeatures.Forms

Namespace AddTooltipToField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load source PDF form
			Dim doc As New Document(dataDir & "input.pdf")

			' Set the tooltip for textfield
			(TryCast(doc.Form("textbox1"), Field)).AlternateName = "Text box tool tip"

			' Save the updated document
			doc.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace