# SimpleFileRenamer
This is a simple console app I first created when learning how to manage files in C#

## Usage:
After building the instructions run the .exe which can be found in the: `ConsoleApp1\bin\Release\` folder. It will prompt you for a full filepath. Afterwards it will ask you for both the original file extension and the new file extension.
Upon completion it will remove all old files as well.

ex:
```
Input a folder path
"C:\Users\BojackHorseman\Desktop\Notes\"
File type to rename
"txt md"
```

This will convert all files located at the specified path from .txt to .md.

## References used:

#### How do you open a file?
https://docs.microsoft.com/en-us/dotnet/api/system.io.file.open?view=netframework-4.7.2
#### How do you change a files extension?
https://docs.microsoft.com/en-us/dotnet/api/system.io.path.changeextension?view=netframework-4.7.2
#### How do you seperate the file path from it's extension?
https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getfilenamewithoutextension?view=netframework-4.7.2
#### How can you grab all the files in a directory?
https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo.directory?view=netframework-4.7.2
#### How do you combine file paths?
https://docs.microsoft.com/en-us/dotnet/api/system.io.path.combine?view=netframework-4.7.2
#### How do you create a release build?
https://docs.microsoft.com/en-us/cpp/build/reference/how-to-create-a-release-build?view=vs-2017
