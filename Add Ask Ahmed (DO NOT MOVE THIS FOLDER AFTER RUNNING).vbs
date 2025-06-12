Set WshShell = CreateObject("WScript.Shell")

Set fso = CreateObject("Scripting.FileSystemObject")
scriptFullPath = WScript.ScriptFullName
scriptFolder = fso.GetParentFolderName(scriptFullPath)

regPath = "HKEY_CLASSES_ROOT\*\shell\AskAhmed\"

exeName = "AhmedAV.exe"

exePath = Chr(34) & scriptFolder & "\" & exeName & Chr(34) & " " & Chr(34) & "%1" & Chr(34)

WshShell.RegWrite regPath & "", "Ask Ahmed", "REG_SZ"
WshShell.RegWrite regPath & "command\", exePath, "REG_SZ"

WScript.Echo "Context menu option 'Ask Ahmed' has been added."
