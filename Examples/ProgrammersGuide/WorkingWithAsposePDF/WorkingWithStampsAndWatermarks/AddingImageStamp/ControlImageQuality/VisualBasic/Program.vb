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

Namespace ControlImageQuality
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim doc As New Document(dataDir & "input.pdf")
			Dim stamp As New ImageStamp(dataDir & "aspose-logo.jpg")
			stamp.Quality = 10
			doc.Pages(1).AddStamp(stamp)
			doc.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace