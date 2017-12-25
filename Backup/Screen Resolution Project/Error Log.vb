﻿Imports System.IO


Public Class Error_Log
    Public Sub WriteToErrorLog(ByVal msg As String, ByVal stkTrace As String, ByVal title As String)

        'check and make the directory if necessary; this is set to look in the application folder, you may wish to place the error log in another location depending upon the user's role and write access to different areas of the file system 
        If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
        End If

        'check the file
        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\" & Location_Code & "_errlog_" & (Date.Now.ToShortDateString).Replace("/", "_") & ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\" & Location_Code & "_errlog_" & (Date.Now.ToShortDateString).Replace("/", "_") & ".txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("================================================" & vbCrLf)
        s1.Write("Title: " & title & vbCrLf)
        s1.Write("Message: " & msg & vbCrLf)
        s1.Write("StackTrace: " & stkTrace & vbCrLf)
        's1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
        s1.Write("================================================" & vbCrLf)
        s1.Write(vbNewLine)

        s1.Close()
        fs1.Close()

    End Sub
End Class