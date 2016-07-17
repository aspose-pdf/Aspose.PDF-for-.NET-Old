Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.WorkingDocument
    Public Class SetViewerPreference
        Public Shared Sub Run()
            ' ExStart:SetViewerPreference
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()
            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "SetViewerPreference.pdf")

            ' Change Viewer Preferences
            contentEditor.ChangeViewerPreference(ViewerPreference.CenterWindow)
            contentEditor.ChangeViewerPreference(ViewerPreference.HideMenubar)
            contentEditor.ChangeViewerPreference(ViewerPreference.PageModeUseNone)

            ' Save output PDF file
            contentEditor.Save(dataDir & "SetViewerPreference_out_.pdf")
            ' ExEnd:SetViewerPreference
        End Sub
    End Class
End Namespace