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
Imports Aspose.Pdf.Facades
Imports System

Namespace GetXMPMetadataExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'create PdfXmpMetadata object
			Dim xmpMetaData As New PdfXmpMetadata()

			'bind pdf file to the object
			xmpMetaData.BindPdf(dataDir & "input.pdf")

			'get XMP Meta Data properties
			Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.CreateDate).ToString())
			Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.MetadataDate).ToString())
			Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.CreatorTool).ToString())
			Console.WriteLine(": {0}", xmpMetaData("customNamespace:UserPropertyName").ToString())

			Console.ReadLine()

		End Sub
	End Class
End Namespace