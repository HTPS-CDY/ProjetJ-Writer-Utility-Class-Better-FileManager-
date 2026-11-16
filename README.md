# ProjetJ-Writer Utility Class++ (FileManager)

> **The direct upgrade to [ProjetJ-Writer-Utility-Class](https://github.com/HTPS-CDY/ProjetJ-Writer-Utility-Class).** 
> More robust, more organized, and with more "soul".

A lightweight, exception-safe file read/write utility library for C#. Built on top of `StreamWriter` and `StreamReader`, but evolved into a more structured toolkit.

## 🚀 What's New in the "++" Version?

- **🏗️ Better Architecture**: Split into dedicated classes (`FileWriter`, `FileReader`, `FileCreator`) instead of cramming everything into one place.
- **🛡️ Unique File Naming**: Built-in dual-random-number collision avoidance mechanism (`CreateUniqueFile`).
- **♻️ Enhanced Resource Management**: Full `using` statements everywhere, so you never lock a file again.
- **📖 Cleaner API**: Methods like `AppendWrite`, `OverwriteWrite`, `ReadToList`, and `ReadAndPrint` make your intent crystal clear.

## 📦 How to Use

```csharp
using FileManagerTools;

// 1. Create a safe, non-colliding file
FileCreator.CreateUniqueFile("my_data.txt");

// 2. Write something (Append mode)
FileWriter.AppendWrite("my_data.txt", "Hello Cyber-Tan!");
FileWriter.AppendWrite("my_data.txt", "Pysharp is the future.");

// 3. Read it back
FileReader.ReadAndPrint("my_data.txt");
