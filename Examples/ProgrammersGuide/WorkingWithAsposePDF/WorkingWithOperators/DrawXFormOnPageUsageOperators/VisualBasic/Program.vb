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

Namespace DrawXFormOnPageUsageOperators
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			Dim imageFile As String = dataDir & "aspose-logo.jpg"
			Dim inFile As String = dataDir & "input.pdf"
			Dim outFile As String = dataDir & "blank-sample2-out.pdf"

			Using doc As New Document(inFile)
				Dim pageContents As OperatorCollection = doc.Pages(1).Contents

				' the sample demonstrates 
				' GSave/GRestore operators usage
				' ContatenateMatrix operator usage to position xForm
				' Do operator usage to draw xForm on page

				' wrap existing contents with GSave/GRestore operators pair
				'        this is to get initial graphics state at the and of existing contents
				'        otherwise there might remain some undesirable transformations at the end of existing operators chain
				pageContents.Insert(1, New Operator.GSave())
				pageContents.Add(New Operator.GRestore())

				' add save graphics state operator to properly clear graphics state after new commands
				pageContents.Add(New Operator.GSave())

'				#Region "create xForm"

				' create xForm
				Dim form As XForm = XForm.CreateNewForm(doc.Pages(1), doc)
				doc.Pages(1).Resources.Forms.Add(form)
				form.Contents.Add(New Operator.GSave())
				' define image width and heigh
				form.Contents.Add(New Operator.ConcatenateMatrix(200, 0, 0, 200, 0, 0))
				' load image into stream
				Dim imageStream As Stream = New FileStream(imageFile, FileMode.Open)
				' add image to Images collection of the XForm Resources
				form.Resources.Images.Add(imageStream)
				Dim ximage As XImage = form.Resources.Images(form.Resources.Images.Count)
				' using Do operator: this operator draws image
				form.Contents.Add(New Operator.Do(ximage.Name))
				form.Contents.Add(New Operator.GRestore())

'				#End Region


				pageContents.Add(New Operator.GSave())
				' place form to the x=100 y=500 coordinates
				pageContents.Add(New Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 500))
				' draw form with Do operator
				pageContents.Add(New Operator.Do(form.Name))
				pageContents.Add(New Operator.GRestore())

				pageContents.Add(New Operator.GSave())
				' place form to the x=100 y=300 coordinates
				pageContents.Add(New Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 300))
				' draw form with Do operator
				pageContents.Add(New Operator.Do(form.Name))
				pageContents.Add(New Operator.GRestore())

				' restore grahics state with GRestore after the GSave
				pageContents.Add(New Operator.GRestore())

				doc.Save(outFile)
			End Using

		End Sub
	End Class
End Namespace