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
Imports System.Collections

Namespace VB.AsposePdf.Operators
    Public Class RemoveGraphicsObjects
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Operators()

            Dim doc As New Document(dataDir & "RemoveGraphicsObjects.pdf")
            Dim page As Page = doc.Pages(2)
            Dim oc As OperatorCollection = page.Contents

            ' used path-painting operators
			Dim operators() As [Operator] = { New Operator.Stroke(), New Operator.ClosePathStroke(), New Operator.Fill() }

            Dim list As New ArrayList()
            For Each op As [Operator] In operators
                Dim os As New OperatorSelector(op)
                oc.Accept(os)
                list.AddRange(os.Selected)
            Next op

            oc.Delete(list)

            doc.Save(dataDir & "No_Graphics.pdf")


        End Sub
    End Class
End Namespace