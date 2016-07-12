Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePDF.Miscellaneous
    Public Class GetBuildInformation
        Public Shared Sub Run()
            ' ExStart:GetBuildInformation
            ' Get version information
            Console.WriteLine("Product : {0}", BuildVersionInfo.Product)
            Console.WriteLine("File Version : {0}", BuildVersionInfo.FileVersion)
            Console.WriteLine("Assembly Version : {0}", BuildVersionInfo.AssemblyVersion)
            ' ExEnd:GetBuildInformation
        End Sub
    End Class
End Namespace
