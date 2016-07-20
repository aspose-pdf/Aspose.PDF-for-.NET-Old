Imports System.Security.Principal
Imports System
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Namespace AsposePDFFacades.Printing
#Region "Using directives."
    ' ----------------------------------------------------------------------


    ' ----------------------------------------------------------------------
#End Region

    '''//////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Impersonation of a user. Allows to execute code under another
    ''' user context.
    ''' Please note that the account that instantiates the Impersonator class
    ''' needs to have the 'Act as part of operating system' privilege set.
    ''' </summary>
    ''' <remarks>	
    ''' This class is based on the information in the Microsoft knowledge base
    ''' article http://support.microsoft.com/default.aspx?scid=kb;en-us;Q306158
    ''' 
    ''' Encapsulate an instance into a using-directive like e.g.:
    ''' 
    '''		...
    '''		using ( new Impersonator( "myUsername", "myDomainname", "myPassword" ) )
    '''		{
    '''			...
    '''			[code that executes under the new context]
    '''			...
    '''		}
    '''		...
    ''' 
    ''' Please contact the author Uwe Keim (mailto:uwe.keim@zeta-software.de)
    ''' for questions regarding this class.
    ''' </remarks>
    Public Class Impersonator
        Implements IDisposable
#Region "Public methods."
        ' ------------------------------------------------------------------

        ''' <summary>
        ''' Constructor. Starts the impersonation with the given credentials.
        ''' Please note that the account that instantiates the Impersonator class
        ''' needs to have the 'Act as part of operating system' privilege set.
        ''' </summary>
        ''' <param name="userName">The name of the user to act as.</param>
        ''' <param name="domainName">The domain name of the user to act as.</param>
        ''' <param name="password">The password of the user to act as.</param>
        Public Sub New(userName As String, domainName As String, password As String)
            ImpersonateValidUser(userName, domainName, password)
        End Sub

        ' ------------------------------------------------------------------
#End Region

#Region "IDisposable member."
        ' ------------------------------------------------------------------

        Public Sub Dispose() Implements System.IDisposable.Dispose
            UndoImpersonation()
        End Sub

        ' ------------------------------------------------------------------
#End Region

#Region "P/Invoke."
        ' ------------------------------------------------------------------

        <DllImport("advapi32.dll", SetLastError:=True)> _
        Private Shared Function LogonUser(lpszUserName As String, lpszDomain As String, lpszPassword As String, dwLogonType As Integer, dwLogonProvider As Integer, ByRef phToken As IntPtr) As Integer
        End Function

        <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function DuplicateToken(hToken As IntPtr, impersonationLevel As Integer, ByRef hNewToken As IntPtr) As Integer
        End Function

        <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function RevertToSelf() As Boolean
        End Function

        <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function CloseHandle(handle As IntPtr) As Boolean
        End Function

        Private Const LOGON32_LOGON_INTERACTIVE As Integer = 2
        Private Const LOGON32_PROVIDER_DEFAULT As Integer = 0

        ' ------------------------------------------------------------------
#End Region

#Region "Private member."
        ' ------------------------------------------------------------------

        ''' <summary>
        ''' Does the actual impersonation.
        ''' </summary>
        ''' <param name="userName">The name of the user to act as.</param>
        ''' <param name="domainName">The domain name of the user to act as.</param>
        ''' <param name="password">The password of the user to act as.</param>
        Private Sub ImpersonateValidUser(userName As String, domain As String, password As String)
            Dim tempWindowsIdentity As WindowsIdentity = Nothing
            Dim token As IntPtr = IntPtr.Zero
            Dim tokenDuplicate As IntPtr = IntPtr.Zero

            Try
                If RevertToSelf() Then
                    If LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, token) <> 0 Then
                        If DuplicateToken(token, 2, tokenDuplicate) <> 0 Then
                            tempWindowsIdentity = New WindowsIdentity(tokenDuplicate)
                            impersonationContext = tempWindowsIdentity.Impersonate()
                        Else
                            Throw New Win32Exception(Marshal.GetLastWin32Error())
                        End If
                    Else
                        Throw New Win32Exception(Marshal.GetLastWin32Error())
                    End If
                Else
                    Throw New Win32Exception(Marshal.GetLastWin32Error())
                End If
            Finally
                If token <> IntPtr.Zero Then
                    CloseHandle(token)
                End If
                If tokenDuplicate <> IntPtr.Zero Then
                    CloseHandle(tokenDuplicate)
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Reverts the impersonation.
        ''' </summary>
        Private Sub UndoImpersonation()
            If impersonationContext IsNot Nothing Then
                impersonationContext.Undo()
            End If
        End Sub

        Private impersonationContext As WindowsImpersonationContext = Nothing

        ' ------------------------------------------------------------------
#End Region

       

        Protected Overrides Sub Finalize()
            Dispose()
            Console.WriteLine("Object " & GetHashCode() & " finalized.")
        End Sub
    End Class

    '''//////////////////////////////////////////////////////////////////////
End Namespace
