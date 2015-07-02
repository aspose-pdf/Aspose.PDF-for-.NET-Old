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

Namespace VisualBasic.AsposePdfGenerator.Text
    Public Class CustomTabStops
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Pdf instance by calling it empty constructor
            Dim pdf As New Aspose.Pdf.Generator.Pdf()

            'Create a text object 
            Dim text1 As New Aspose.Pdf.Generator.Text("This #$TAB is a example for custom TAB stop positions.")

            'Assign an instance of TabStops to the TabStops property of text object
            text1.TabStops = New Aspose.Pdf.Generator.TabStops()

            'Call Add method of TabStops and pass a specified position as argument
            text1.TabStops.Add(150)

            'Call Add method with specified position and tab leader type as Dot
            text1.TabStops.Add(350, Aspose.Pdf.Generator.TabLeaderType.Dot)

            pdf.Save(dataDir & "Output.pdf")

        End Sub
    End Class
End Namespace