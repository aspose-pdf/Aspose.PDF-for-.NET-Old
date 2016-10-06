Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ConcatenatePdfFilesAndCreateTOC
        Public Shared Sub Run()
            ' ExStart:ConcatenatePdfFilesAndCreateTOC
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Save concatenated output file
            pdfEditor.Concatenate(New FileStream(dataDir & Convert.ToString("input1.pdf"), FileMode.Open), New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open), New FileStream(dataDir & Convert.ToString("ConcatenatePdfFilesAndCreateTOC_out_.pdf"), FileMode.Create))
            ' ExEnd:ConcatenatePdfFilesAndCreateTOC                      
        End Sub
        Public Shared Sub InsertBlankPage()
            ' ExStart:InsertBlankPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Insert a blank page at the begining of concatenated file to display Table of Contents
            Dim concatenated_pdfDocument As New Aspose.Pdf.Document(New FileStream(dataDir & Convert.ToString("Concatenated_Table_Of_Contents.pdf"), FileMode.Open))
            ' Insert a empty page in a PDF
            concatenated_pdfDocument.Pages.Insert(1)
            ' ExEnd:InsertBlankPage
        End Sub
        Public Shared Sub AddTextStamps()
            ' ExStart:AddTextStamps
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Set Text Stamp to display string Table Of Contents
            Dim stamp As New Aspose.Pdf.Facades.Stamp()
            stamp.BindLogo(New FormattedText("Table Of Contents", System.Drawing.Color.Maroon, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, True, _
                18))
            ' Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
            stamp.SetOrigin((New PdfFileInfo(New FileStream(dataDir & Convert.ToString("input1.pdf"), FileMode.Open)).GetPageWidth(1) / 3), 700)
            ' Set particular pages
            stamp.Pages = New Integer() {1}
            ' ExEnd:AddTextStamps
        End Sub
        Public Shared Sub CreateLocalLinks()
            ' ExStart:CreateLocalLinks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Now we need to add Heading for Table Of Contents and links for documents
            Dim contentEditor As New PdfContentEditor()
            ' Bind the PDF file in which we added the blank page
            contentEditor.BindPdf(New FileStream(dataDir & Convert.ToString("Concatenated_Table_Of_Contents.pdf"), FileMode.Open))
            ' Create link for first document
            contentEditor.CreateLocalLink(New System.Drawing.Rectangle(150, 650, 100, 20), 2, 1, System.Drawing.Color.Transparent)
            ' ExEnd:CreateLocalLinks
        End Sub
        Public Shared Sub CompletedCode()
            ' ExStart:CompletedCode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create a MemoryStream object to hold the resultant PDf file
            Using Concatenated_Stream As New MemoryStream()
                ' Save concatenated output file
                pdfEditor.Concatenate(New FileStream(dataDir & Convert.ToString("input1.pdf"), FileMode.Open), New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open), Concatenated_Stream)
                ' Insert a blank page at the begining of concatenated file to display Table of Contents
                Dim concatenated_pdfDocument As New Aspose.Pdf.Document(Concatenated_Stream)
                ' Insert a empty page in a PDF
                concatenated_pdfDocument.Pages.Insert(1)

                ' Hold the resultnat file with empty page added
                Using Document_With_BlankPage As New MemoryStream()
                    ' Save output file
                    concatenated_pdfDocument.Save(Document_With_BlankPage)

                    Using Document_with_TOC_Heading = New MemoryStream()
                        ' Add Table Of Contents logo as stamp to PDF file
                        Dim fileStamp As New PdfFileStamp()
                        ' Find the input file
                        fileStamp.BindPdf(Document_With_BlankPage)

                        ' Set Text Stamp to display string Table Of Contents
                        Dim stamp As New Aspose.Pdf.Facades.Stamp()
                        stamp.BindLogo(New FormattedText("Table Of Contents", System.Drawing.Color.Maroon, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, True, _
                            18))
                        ' Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        stamp.SetOrigin((New PdfFileInfo(Document_With_BlankPage).GetPageWidth(1) / 3), 700)
                        ' Set particular pages
                        stamp.Pages = New Integer() {1}
                        ' Add stamp to PDF file
                        fileStamp.AddStamp(stamp)

                        ' Create stamp text for first item in Table Of Contents
                        Dim Document1_Link = New Aspose.Pdf.Facades.Stamp()
                        Document1_Link.BindLogo(New FormattedText("1 - Link to Document 1", System.Drawing.Color.Black, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, True, _
                            12))
                        ' Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        Document1_Link.SetOrigin(150, 650)
                        ' Set particular pages on which stamp should be displayed
                        Document1_Link.Pages = New Integer() {1}
                        ' Add stamp to PDF file
                        fileStamp.AddStamp(Document1_Link)

                        ' Create stamp text for second item in Table Of Contents
                        Dim Document2_Link = New Aspose.Pdf.Facades.Stamp()
                        Document2_Link.BindLogo(New FormattedText("2 - Link to Document 2", System.Drawing.Color.Black, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, True, _
                            12))
                        ' Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        Document2_Link.SetOrigin(150, 620)
                        ' Set particular pages on which stamp should be displayed
                        Document2_Link.Pages = New Integer() {1}
                        ' Add stamp to PDF file
                        fileStamp.AddStamp(Document2_Link)

                        ' Save updated PDF file
                        fileStamp.Save(Document_with_TOC_Heading)
                        fileStamp.Close()

                        ' Now we need to add Heading for Table Of Contents and links for documents
                        Dim contentEditor As New PdfContentEditor()
                        ' Bind the PDF file in which we added the blank page
                        contentEditor.BindPdf(Document_with_TOC_Heading)
                        ' Create link for first document
                        contentEditor.CreateLocalLink(New System.Drawing.Rectangle(150, 650, 100, 20), 2, 1, System.Drawing.Color.Transparent)
                        ' Create link for Second document
                        ' We have used   new PdfFileInfo("d:/pdftest/Input1.pdf").NumberOfPages + 2   as PdfFileInfo.NumberOfPages(..) returns the page count for first document
                        ' and 2 is because, second document will start at Input1+1 and 1 for the page containing Table Of Contents.
                        contentEditor.CreateLocalLink(New System.Drawing.Rectangle(150, 620, 100, 20), New PdfFileInfo(dataDir & Convert.ToString("Input1.pdf")).NumberOfPages + 2, 1, System.Drawing.Color.Transparent)

                        ' Save updated PDF
                        contentEditor.Save(dataDir & Convert.ToString("Concatenated_Table_Of_Contents.pdf"))
                    End Using
                End Using
            End Using
            ' ExEnd:CompletedCode
        End Sub
    End Class
End Namespace
