namespace WindowAPI.console
{
    public static class Functions
    {

        /// <summary>
        ///Defines a console alias for the specified executable.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AddConsoleAlias(string Source, string Target, string ExeName);

        /// <summary>
        ///Allocates a new console for the calling process.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AllocConsole();

        /// <summary>
        ///Attaches the calling process to the console of the specified process as a client application.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AttachConsole(uint dwProcessId);

        /// <summary>
        ///Closes a pseudoconsole from the given handle.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ClosePseudoConsole(nint hPC);

        /// <summary>
        ///Creates a new pseudoconsole object for the calling process.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePseudoConsole(COORD size, nint hInput, nint hOutput, uint dwFlags, out nint phPC);

        /// <summary>
        ///Creates a console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateConsoleScreenBuffer(uint dwDesiredAccess, uint dwShareMode, SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwFlags, nint lpScreenBufferData);

        /// <summary>
        ///Sets the character attributes for a specified number of character cells, beginning at the specified coordinates in a screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FillConsoleOutputAttribute(nint hConsoleOutput, short wAttribute, uint nLength, COORD dwWriteCoord, out uint lpNumberOfAttrsWritten);

        /// <summary>
        ///Writes a character to the console screen buffer a specified number of times, beginning at the specified coordinates.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FillConsoleOutputCharacter(nint hConsoleOutput, char cCharacter, uint nLength, COORD dwWriteCoord, out uint lpNumberOfCharsWritten);

        /// <summary>
        ///Flushes the console input buffer. All input records currently in the input buffer are discarded.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FlushConsoleInputBuffer(nint hConsoleInput);

        /// <summary>
        ///Detaches the calling process from its console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FreeConsole();

        /// <summary>
        ///Sends a specified signal to a console process group that shares the console associated with the calling process.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

        /// <summary>
        ///Retrieves the text for the specified console alias and executable.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleAlias(string lpSource, out string lpTargetBuffer, uint TargetBufferLength, string lpExeName);

        /// <summary>
        ///Retrieves all defined console aliases for the specified executable.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleAliases(out string lpAliasBuffer, uint AliasBufferLength, string lpExeName);

        /// <summary>
        ///Retrieves the required size for the buffer used by the GetConsoleAliases function.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleAliasesLength(string lpExeName);

        /// <summary>
        ///Retrieves the names of all executable files with console aliases defined.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleAliasExes(out string lpExeNameBuffer, uint ExeNameBufferLength);

        /// <summary>
        ///Retrieves the required size for the buffer used by the GetConsoleAliasExes function.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleAliasExesLength();

        /// <summary>
        ///Retrieves the input code page used by the console associated with the calling process. A console uses its input code page to translate keyboard input into the corresponding character value.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleCP();

        /// <summary>
        ///Retrieves information about the size and visibility of the cursor for the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleCursorInfo(nint hConsoleOutput, out CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        /// <summary>
        ///Retrieves the display mode of the current console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleDisplayMode(out uint lpModeFlags);

        /// <summary>
        ///Retrieves the size of the font used by the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern COORD GetConsoleFontSize(nint hConsoleOutput, uint nFont);

        /// <summary>
        ///Retrieves the history settings for the calling process's console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleHistoryInfo(out CONSOLE_HISTORY_INFO lpConsoleHistoryInfo);

        /// <summary>
        ///Retrieves the current input mode of a console's input buffer or the current output mode of a console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleMode(nint hConsoleHandle, out uint lpMode);

        /// <summary>
        ///Retrieves the original title for the current console window.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleOriginalTitle(out string lpConsoleTitle, uint nSize);

        /// <summary>
        ///Retrieves the output code page used by the console associated with the calling process. A console uses its output code page to translate the character values written by the various output functions into the images displayed in the console window.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleOutputCP();

        /// <summary>
        ///Retrieves a list of the processes attached to the current console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleProcessList(out uint lpdwProcessList, uint dwProcessCount);

        /// <summary>
        ///Retrieves information about the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleScreenBufferInfo(nint hConsoleOutput, out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);

        /// <summary>
        ///Retrieves extended information about the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleScreenBufferInfoEx(nint hConsoleOutput, out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfoEx);

        /// <summary>
        ///Retrieves information about the current console selection.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetConsoleSelectionInfo(out CONSOLE_CURSOR_INFO lpConsoleSelectionInfo);

        /// <summary>
        ///Retrieves the title for the current console window.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetConsoleTitle(out string lpConsoleTitle, uint nSize);

        /// <summary>
        ///Retrieves the window handle used by the console associated with the calling process.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetConsoleWindow();

        /// <summary>
        ///Retrieves information about the current console font.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentConsoleFont(nint hConsoleOutput, bool bMaximumWindow, out CONSOLE_FONT_INFO lpConsoleCurrentFont);

        /// <summary>
        ///Retrieves extended information about the current console font.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, out CONSOLE_FONT_INFOEX lpConsoleCurrentFontEx);

        /// <summary>
        ///Retrieves the size of the largest possible console window, based on the current font and the size of the display.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern COORD GetLargestConsoleWindowSize(nint hConsoleOutput);

        /// <summary>
        ///Retrieves the number of unread input records in the console's input buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumberOfConsoleInputEvents(nint hConsoleInput, out uint lpcNumberOfEvents);

        /// <summary>
        ///Retrieves the number of buttons on the mouse used by the current console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumberOfConsoleMouseButtons(out uint lpNumberOfMouseButtons);

        /// <summary>
        ///Retrieves a handle to the specified standard device (standard input, standard output, or standard error).
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetStdHandle(int nStdHandle);

        /// <summary>
        ///An application-defined function used with the SetConsoleCtrlHandler function. A console process uses this function to handle control signals received by the process. When the signal is received, the system creates a new thread in the process to execute the function.
        /// </summary>

        [DllImport("quick[1]", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool HandlerRoutine(uint dwCtrlType);

        /// <summary>
        ///Reads data from the specified console input buffer without removing it from the buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PeekConsoleInput(nint hConsoleInput, out INPUT_RECORD lpBuffer, uint nLength, out uint lpNumberOfEventsRead);

        /// <summary>
        ///Reads character input from the console input buffer and removes it from the buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsole(nint hConsoleInput, out nint lpBuffer, uint nNumberOfCharsToRead, out uint lpNumberOfCharsRead, nint pInputControl);

        /// <summary>
        ///Reads data from a console input buffer and removes it from the buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleInput(nint hConsoleInput, out INPUT_RECORD lpBuffer, uint nLength, out uint lpNumberOfEventsRead);

        /// <summary>
        ///Reads data from a console input buffer and removes it from the buffer, with configurable behavior.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleInputEx(nint hConsoleInput, out INPUT_RECORD lpBuffer, uint nLength, out uint lpNumberOfEventsRead, ushort wFlags);

        /// <summary>
        ///Reads character and color attribute data from a rectangular block of character cells in a console screen buffer, and the function writes the data to a rectangular block at a specified location in the destination buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleOutput(nint hConsoleOutput, out CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord);

        /// <summary>
        ///Copies a specified number of character attributes from consecutive cells of a console screen buffer, beginning at a specified location.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleOutputAttribute(nint hConsoleOutput, out uint lpAttribute, uint nLength, COORD dwReadCoord, out uint lpNumberOfAttrsRead);

        /// <summary>
        ///Copies a number of characters from consecutive cells of a console screen buffer, beginning at a specified location.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleOutputCharacter(nint hConsoleOutput, out string lpCharacter, uint nLength, COORD dwReadCoord, out uint lpNumberOfCharsRead);

        /// <summary>
        ///Resizes the internal buffers for a pseudoconsole to the given size.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint ResizePseudoConsole(nint hPC, COORD size);

        /// <summary>
        ///Moves a block of data in a screen buffer. The effects of the move can be limited by specifying a clipping rectangle, so the contents of the console screen buffer outside the clipping rectangle are unchanged.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ScrollConsoleScreenBuffer(nint hConsoleOutput, SMALL_RECT lpScrollRectangle, SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, CHAR_INFO lpFill);

        /// <summary>
        ///Sets the specified screen buffer to be the currently displayed console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleActiveScreenBuffer(nint hConsoleOutput);

        /// <summary>
        ///Sets the input code page used by the console associated with the calling process. A console uses its input code page to translate keyboard input into the corresponding character value.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleCP(uint wCodePageID);

        /// <summary>
        ///Adds or removes an application-defined HandlerRoutine function from the list of handler functions for the calling process.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleCtrlHandler(nint HandlerRoutine, bool Add);

        /// <summary>
        ///Sets the size and visibility of the cursor for the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleCursorInfo(nint hConsoleOutput, CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        /// <summary>
        ///Sets the cursor position in the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleCursorPosition(nint hConsoleOutput, COORD dwCursorPosition);

        /// <summary>
        ///Sets the display mode of the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleDisplayMode(nint hConsoleOutput, uint dwFlags, out COORD lpNewScreenBufferDimensions);

        /// <summary>
        ///Sets the history settings for the calling process's console.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleHistoryInfo(CONSOLE_HISTORY_INFO lpConsoleHistoryInfo);

        /// <summary>
        ///Sets the input mode of a console's input buffer or the output mode of a console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleMode(nint hConsoleHandle, uint dwMode);

        /// <summary>
        ///Sets the output code page used by the console associated with the calling process. A console uses its output code page to translate the character values written by the various output functions into the images displayed in the console window.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);

        /// <summary>
        ///Sets extended information about the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleScreenBufferInfoEx(nint hConsoleOutput, CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfoEx);

        /// <summary>
        ///Changes the size of the specified console screen buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleScreenBufferSize(nint hConsoleOutput, COORD dwSize);

        /// <summary>
        ///Sets the attributes of characters written to the console screen buffer by the WriteFile or WriteConsole function, or echoed by the ReadFile or ReadConsole function. This function affects text written after the function call.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleTextAttribute(nint hConsoleOutput, short wAttributes);

        /// <summary>
        ///Sets the title for the current console window.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleTitle(string lpConsoleTitle);

        /// <summary>
        ///Sets the current size and position of a console screen buffer's window.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetConsoleWindowInfo(nint hConsoleOutput, bool bAbsolute, SMALL_RECT lpConsoleWindow);

        /// <summary>
        ///Sets extended information about the current console font.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, CONSOLE_FONT_INFOEX lpConsoleCurrentFontEx);

        /// <summary>
        ///Sets the handle for the specified standard device (standard input, standard output, or standard error).
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetStdHandle(int nStdHandle, nint hHandle);

        /// <summary>
        ///Writes a character string to a console screen buffer beginning at the current cursor location.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteConsole(nint hConsoleOutput, string lpBuffer, uint nNumberOfCharsToWrite, out int lpNumberOfCharsWritten, nint lpReserved);

        /// <summary>
        ///Writes data directly to the console input buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteConsoleInput(nint hConsoleInput, INPUT_RECORD lpBuffer, uint nLength, out uint lpNumberOfEventsWritten);

        /// <summary>
        ///Writes character and color attribute data to a specified rectangular block of character cells in a console screen buffer. The data to be written is taken from a correspondingly sized rectangular block at a specified location in the source buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteConsoleOutput(nint hConsoleOutput, CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord);

        /// <summary>
        ///Copies a number of character attributes to consecutive cells of a console screen buffer, beginning at a specified location.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteConsoleOutputAttribute(nint hConsoleOutput, short lpAttribute, uint nLength, COORD dwWriteCoord, out uint lpNumberOfAttrsWritten);

        /// <summary>
        ///Copies a number of characters to consecutive cells of a console screen buffer, beginning at a specified location.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteConsoleOutputCharacter(nint hConsoleOutput, string lpCharacter, uint nLength, COORD dwWriteCoord, out uint lpNumberOfCharsWritten);


    }
}