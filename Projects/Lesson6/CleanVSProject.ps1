Get-ChildItem .\ -include bin,obj,.vs,packages -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }