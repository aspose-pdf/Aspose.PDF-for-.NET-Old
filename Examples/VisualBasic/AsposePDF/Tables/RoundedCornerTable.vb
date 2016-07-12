Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Tables
    Public Class RoundedCornerTable
        Public Shared Sub Run()
            ' ExStart:RoundedCornerTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()
            Dim tab1 As New Table()

            Dim graph As New GraphInfo()
            graph.Color = Color.Red
            ' Create a blank BorderInfo object
            Dim bInfo As New BorderInfo(BorderSide.All, graph)
            ' Set the border a rounder border where radius of round is 15
            bInfo.RoundedBorderRadius = 15
            ' Set the table Corner style as Round.
            tab1.CornerStyle = BorderCornerStyle.Round
            ' Set the table border information
            tab1.Border = bInfo
            ' ExEnd:RoundedCornerTable

        End Sub
    End Class
End Namespace