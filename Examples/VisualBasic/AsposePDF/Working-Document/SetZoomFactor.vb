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
Imports Aspose.Pdf.InteractiveFeatures

Namespace VisualBasic.AsposePdf.WorkingDocuments
    Public Class SetZoomFactor
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' instantiate new Document object
            Dim doc As New Document(dataDir & "SetZoomFactor.pdf")

            'Set Left Right and Z factors
            Dim parameters() As Double = {0, 0, 10}

            'Set Explicit Destination
            Dim ED As ExplicitDestination = ExplicitDestination.CreateDestination(1, ExplicitDestinationType.XYZ, parameters)

            'Set Action 
            Dim action As New GoToAction(ED)

            'Set Open action of document
            doc.OpenAction = action

            'Save the document
            doc.Save(dataDir & "Zoomed_pdf.pdf")
        End Sub
    End Class
End Namespace