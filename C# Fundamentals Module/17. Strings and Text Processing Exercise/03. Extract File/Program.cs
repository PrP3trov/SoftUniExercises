string filePath = Console.ReadLine();
string fileName = "";
string fileExtension = "";
int lastSeparator = filePath.LastIndexOf('\\');
int extensionIndex = filePath.LastIndexOf('.');
if (lastSeparator != -1 && extensionIndex != -1 && lastSeparator < extensionIndex)
{
    fileName = filePath.Substring(lastSeparator+1, extensionIndex - lastSeparator -1 );
    fileExtension = filePath.Substring(extensionIndex + 1);
}
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");
