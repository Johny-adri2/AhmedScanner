Set WshShell = CreateObject("WScript.Shell")

regPath = "HKEY_CLASSES_ROOT\*\shell\AskAhmed\"

WshShell.RegDelete regPath

WScript.Echo "Context menu option 'Ask Ahmed' has been removed."