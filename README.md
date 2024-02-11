# WindowAPI/Wrapper

`WindowAPIWrapper` is a C# library designed to simplify the interaction with key components of the Windows API. This project brings together a collection of PInvoke wrappers for various headers like `FontSub`, `OleCtl`, `Prnasnot`, and `Winbase`, enabling .NET developers to easily integrate Windows native functionalities into their applications.

## Features

- **Font Management:** Wrappers around `FontSub.h` for font substitution and management.
- **OLE Controls:** Easy integration with OLE control interfaces via `OleCtl.h`.
- **Printer Notifications:** Support for printer notifications and settings through `Prnasnot.h`.
- **Basic Windows Operations:** Simplified access to fundamental Windows base operations provided by `Winbase.h`.
- **Be Expecting More!**
## Getting Started

To use `WindowAPIWrapper` in your project, follow these steps:

(Here, you would provide instructions on how to install or include your library in a project, possibly with code snippets for basic usage.)

Example:

```cssharp
using static WindowAPI.Winbase.h.Functions;
IntPtr h = LocalAlloc(0, 255);
for (byte i = 0; i < 254; i++)
{
    unsafe
    {

        *(byte*)(h + i) = i;
        Console.WriteLine($"{h + i}: {*(byte*)(h + i)}");
    }
}
LocalFree(h);
```
