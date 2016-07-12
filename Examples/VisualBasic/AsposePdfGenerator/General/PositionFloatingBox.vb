Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.General
    Public Class PositionFloatingBox
        Public Shared Sub Run()
            Try
                ' ExStart:PositionFloatingBox
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_General()

                ' Instantiate Pdf instance by calling its empty constructor
                Dim pdf1 As New AP.Generator.Pdf()
                ' Create section object and add it to sections collection of PDF
                Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()
                ' Create FloatingBox with 108 as width and 80 as height
                Dim box1 As New AP.Generator.FloatingBox(108, 80)
                ' add FloatingBox to paragraphs collection of section object
                sec1.Paragraphs.Add(box1)
                ' ExStart:PositionFloatingBox-1
                ' Specify the Horizontal Positioning type for FloatingBox as Margin
                box1.BoxHorizontalPositioning = AP.Generator.BoxHorizontalPositioningType.Margin
                ' Set the left margin information as 200
                box1.Left = 200
                ' Specify the Vertical Positioning type for FloatingBox object
                box1.BoxVerticalPositioning = AP.Generator.BoxVerticalPositioningType.Page
                ' Set the Top margin information as 300
                box1.Top = 300
                ' ExEnd:PositionFloatingBox-1
                ' Add sample text string to paragraphs collection of FloatingBox object
                box1.Paragraphs.Add(New AP.Generator.Text("Hello."))

                dataDir = dataDir & Convert.ToString("PositionFloatingBox_out_.pdf")
                ' Save the resultant PDF
                ' ExEnd:PositionFloatingBox
                pdf1.Save(dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace