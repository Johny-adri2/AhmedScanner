If Not WScript.Arguments.Named.Exists("elevate") Then
  CreateObject("Shell.Application").ShellExecute WScript.FullName _
    , """" & WScript.ScriptFullName & """ /elevate", "", "runas", 1
  WScript.Quit
End If

Set WshShell = CreateObject("WScript.Shell")

regPath = "HKEY_CLASSES_ROOT\*\shell\AskAhmed\"

WshShell.RegDelete regPath

WScript.Echo "Context menu option 'Ask Ahmed' has been removed."