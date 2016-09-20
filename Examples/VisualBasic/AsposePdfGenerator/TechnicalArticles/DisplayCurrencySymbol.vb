Imports System.IO
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class DisplayCurrencySymbol
        Public Shared Sub Run()
            ' ExStart:DisplayCurrencySymbol           
            ' Create an object of TableFormatInfo class.
            Dim tfi As New Aspose.Pdf.Generator.TableFormatInfo()

            ' Sets a string value that indicate currency symbol of money, the default is "$".
            tfi.CurrencySymbol = "$"
            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Format the table in specified columns and rows with given TableFormatInfo
            tab1.FormatTableWithFormatInfo(tfi, 1, 1, 1, 1)
            ' ExEnd:DisplayCurrencySymbol           
        End Sub
    End Class
End Namespace

