Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.WorkingDocuments
    Public Class AddJavaScript
        Public Shared Sub Run()
            ' ExStart:AddJavaScript
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate a PDF Object 
            Dim pdf As New AP.Generator.Pdf()

            ' Instantiate a Aspose PDF JavaScript Object
            pdf.JavaScripts = New AP.Generator.JavaScripts()

            ' Call the Add method and pass JavaScript statement as an argument, to show Print Dialog
            pdf.JavaScripts.Add("this.print(true);")

            ' Call the Add method and JavaScript statement as an argument, to show alert
            pdf.JavaScripts.Add("app.alert(""hello world"");")
            dataDir = dataDir & Convert.ToString("AddJavaScript_out_.pdf")
            ' Save Pdf Document
            pdf.Save(dataDir)
            ' ExEnd:AddJavaScript
            Console.WriteLine(Convert.ToString(vbLf & "Javascript added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
