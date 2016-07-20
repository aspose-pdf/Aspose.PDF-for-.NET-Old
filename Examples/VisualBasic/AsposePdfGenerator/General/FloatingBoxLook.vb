Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports APG = Aspose.Pdf.Generator

Namespace AsposePdfGenerator.General
    Public Class FloatingBoxLook
        Public Shared Sub Run()
            Try
                ' ExStart:FloatingBoxLook
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_General()

                ' Instantiate Pdf instance by calling its empty constructor
                Dim pdf1 As New APG.Pdf()
                ' Create section object and add it to sections collection of PDF
                Dim sec1 As APG.Section = pdf1.Sections.Add()

                ' Create FloatingBox with 108 as width and 80 as height
                Dim box1 As New APG.FloatingBox(108, 80)
                ' Add FloatingBox to paragraphs collection of section object
                sec1.Paragraphs.Add(box1)
                ' ExStart:FloatingBoxPositionEnum 
                box1.BoxHorizontalPositioning = APG.BoxHorizontalPositioningType.Margin
                box1.BoxHorizontalAlignment = APG.BoxHorizontalAlignmentType.Right
                box1.BoxVerticalPositioning = APG.BoxVerticalPositioningType.Page
                box1.BoxVerticalAlignment = APG.BoxVerticalAlignmentType.Center
                ' ExEnd:FloatingBoxPositionEnum
                ' Add sample text string to paragraphs collection of FloatingBox object
                box1.Paragraphs.Add(New APG.Text("Hello."))

                dataDir = dataDir & Convert.ToString("FloatingBox_out_.pdf")
                ' Save the resultant PDF
                ' ExEnd:FloatingBoxLook
                pdf1.Save(dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace
