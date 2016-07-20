Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class CustomTabStops
        Public Shared Sub Run()
            ' ExStart:CustomTabStops
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf As New AP.Generator.Pdf()

            ' Create a text object 
            Dim text1 As New AP.Generator.Text("This #$TAB is a example for custom TAB stop positions.")

            ' Assign an instance of TabStops to the TabStops property of text object
            text1.TabStops = New AP.Generator.TabStops()

            ' Call Add method of TabStops and pass a specified position as argument
            text1.TabStops.Add(150)

            ' Call Add method with specified position and tab leader type as Dot
            text1.TabStops.Add(350, AP.Generator.TabLeaderType.Dot)

            pdf.Save(dataDir & Convert.ToString("CustomTabStops_out_.pdf"))
            ' ExEnd:CustomTabStops
        End Sub
    End Class
End Namespace
