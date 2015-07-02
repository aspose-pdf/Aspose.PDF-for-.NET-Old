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
Imports System

Namespace VisualBasic.AsposePdf.Forms
    Public Class GetXFAProperties
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' load XFA form
            Dim doc As New Document(dataDir & "GetXFAProperties.pdf")

            Dim names() As String = doc.Form.XFA.FieldNames

            'set field values
            doc.Form.XFA(names(0)) = "Field 0"
            doc.Form.XFA(names(1)) = "Field 1"

            'get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names(0)).Attributes("x").Value)

            'get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names(0)).Attributes("y").Value)

            ' save the updated document
            doc.Save(dataDir & "Filled_XFA.pdf")

        End Sub
    End Class
End Namespace