Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class GetButtonOptionValue
        Public Shared Sub Run()
            Try
                ' ExStart:GetButtonOptionValue
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

                ' Create Form Object
                Dim pdfForm As New Aspose.Pdf.Facades.Form()

                ' Open Document
                pdfForm.BindPdf(dataDir & Convert.ToString("FormField.pdf"))

                ' Get button option values
                Dim optionValues = pdfForm.GetButtonOptionValues("Gender")

                Dim optionValueEnumerator As IDictionaryEnumerator = optionValues.GetEnumerator()

                While optionValueEnumerator.MoveNext()
                    Console.WriteLine("Key : {0} , Value : {1} ", optionValueEnumerator.Key, optionValueEnumerator.Value)
                    ' ExEnd:GetButtonOptionValue
                End While
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Public Shared Sub GetCurrentValue()
            ' ExStart:GetCurrentValue
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            ' Create Form Object
            Dim pdfForm As New Aspose.Pdf.Facades.Form()

            ' Open Document
            pdfForm.BindPdf(dataDir & Convert.ToString("FormField.pdf"))

            ' Get button option values
            Dim optionValue As String = pdfForm.GetButtonOptionCurrentValue("Gender")

            Console.WriteLine("Current Value : {0} ", optionValue)
            ' ExEnd:GetCurrentValue
        End Sub
    End Class
End Namespace

