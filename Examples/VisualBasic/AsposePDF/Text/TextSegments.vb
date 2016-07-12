Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Namespace AsposePDF.Text
    Public Class TextSegments
        Public Shared Sub Run()

            ' ExStart:TextSegments
            Dim textFragmentAbsorber As TextFragmentAbsorber
            ' In order to search exact match of a word, you may consider using regular expression.
            textFragmentAbsorber = New TextFragmentAbsorber("\bWord\b", New TextSearchOptions(True))

            ' In order to search a string in either upper case or lowercase, you may consider using regular expression.
            textFragmentAbsorber = New TextFragmentAbsorber("(?i)Line", New TextSearchOptions(True))

            ' In order to search all the strings (parse all strings) inside PDF document, please try using following regular expression.
            textFragmentAbsorber = New TextFragmentAbsorber("[\S]+")

            ' Find match of search string and get anything after the string till line break.
            textFragmentAbsorber = New TextFragmentAbsorber("(?i)the ((.)*)")

            ' Please use following regular expression to find text following to the regex match.
            textFragmentAbsorber = New TextFragmentAbsorber("(?<=word).*")

            ' In order to search Hyperlink/URL's inside PDF document, please try using following regular expression.
            textFragmentAbsorber = New TextFragmentAbsorber("(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?")

            ' ExEnd: TextSegments
        End Sub
    End Class
End Namespace