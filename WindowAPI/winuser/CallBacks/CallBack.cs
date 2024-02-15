namespace WindowAPI.winuser.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///Application-defined callback function used with the CreateDialog and DialogBox families of functions. It processes messages sent to a modal or modeless dialog box. The DLGPROC type defines a pointer to this callback function. DialogProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate int DLGPROC(nint unnamedParam1, uint unnamedParam2, nint unnamedParam3, nint unnamedParam4);

        /// <summary>
        ///The DrawStateProc function is an application-defined callback function that renders a complex image for the DrawState function. The DRAWSTATEPROC type defines a pointer to this callback function. DrawStateProc is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="hdc">A handle to the device context to draw in. The device context is a memory device context with a bitmap selected, the dimensions of which are at least as great as those specified by the cx and cy parameters.</param>
        /// <param name="lData">Specifies information about the image, which the application passed to DrawState.</param>
        /// <param name="wData">Specifies information about the image, which the application passed to DrawState.</param>
        /// <param name="cx">The image width, in device units, as specified by the call to DrawState.</param>
        /// <param name="cy">The image height, in device units, as specified by the call to DrawState.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.DrawStatePainting and Drawing FunctionsPainting and Drawing Overview</param>

        public delegate bool DRAWSTATEPROC(nint hdc, nint lData, nint wData, int cx, int cy);

        /// <summary>
        ///An application-defined callback function used with the EM_SETWORDBREAKPROC message. A multiline edit control or a rich edit control calls an EditWordBreakProc function to break a line of text.
        /// </summary>
        /// <param name="lpch">Type: LPTSTRA pointer to the text of the edit control.</param>
        /// <param name="ichCurrent">Type: intAn index to a character position in the buffer of text that identifies the point at which the function should begin checking for a word break.</param>
        /// <param name="cch">Type: intThe number of TCHARs in the edit control text. For the ANSI text, this is the number of bytes; for the Unicode text, this is the number of WCHARs.</param>
        /// <param name="code">Type: intThe action to be taken by the callback function. This parameter can be one of the following values.Type: intIf the code parameter specifies WB_ISDELIMITER, the return value is nonzero (TRUE) if the character at the specified position is a delimiter, or zero if it is not. If the code parameter specifies WB_CLASSIFY, the return value is the character class and word break flags of the character at the specified position. Otherwise, the return value is an index to the beginning of a word in the buffer of text.A carriage return followed by a line feed must be treated as a single word by the callback function. Two carriage returns followed by a line feed also must be treated as a single word.An application must install the callback function by specifying the address of the callback function in an EM_SETWORDBREAKPROC message.Rich Edit 1.0:Microsoft Rich Edit 1.0 only passes back ANSI characters to EditWordBreakProc. For rich edit controls, you can alternately use the EM_SETWORDBREAKPROCEX message to replace the default extended word break procedure with an EditWordBreakProcEx callback function. This function provides additional information about the text, such as the character set.Rich Edit 2.0 and later:Microsoft Rich Edit 2.0 and later only pass back Unicode characters to EditWordBreakProc. Thus, an ANSI application would convert the Rich Edit-supplied Unicode string using WideCharToMultiByte, and then translate the indices appropriately.EM_FINDWORDBREAKEM_SETWORDBREAKPROCEM_SETWORDBREAKPROCEXEditWordBreakProcExOther ResourcesReferenceSendMessage</param>

        public delegate int EDITWORDBREAKPROCA(string lpch, int ichCurrent, int cch, int code);

        /// <summary>
        ///An application-defined callback function used with the EM_SETWORDBREAKPROC message. A multiline edit control or a rich edit control calls an EditWordBreakProc function to break a line of text.
        /// </summary>
        /// <param name="lpch">Type: LPTSTRA pointer to the text of the edit control.</param>
        /// <param name="ichCurrent">Type: intAn index to a character position in the buffer of text that identifies the point at which the function should begin checking for a word break.</param>
        /// <param name="cch">Type: intThe number of TCHARs in the edit control text. For the ANSI text, this is the number of bytes; for the Unicode text, this is the number of WCHARs.</param>
        /// <param name="code">Type: intThe action to be taken by the callback function. This parameter can be one of the following values.Type: intIf the code parameter specifies WB_ISDELIMITER, the return value is nonzero (TRUE) if the character at the specified position is a delimiter, or zero if it is not. If the code parameter specifies WB_CLASSIFY, the return value is the character class and word break flags of the character at the specified position. Otherwise, the return value is an index to the beginning of a word in the buffer of text.A carriage return followed by a line feed must be treated as a single word by the callback function. Two carriage returns followed by a line feed also must be treated as a single word.An application must install the callback function by specifying the address of the callback function in an EM_SETWORDBREAKPROC message.Rich Edit 1.0:Microsoft Rich Edit 1.0 only passes back ANSI characters to EditWordBreakProc. For rich edit controls, you can alternately use the EM_SETWORDBREAKPROCEX message to replace the default extended word break procedure with an EditWordBreakProcEx callback function. This function provides additional information about the text, such as the character set.Rich Edit 2.0 and later:Microsoft Rich Edit 2.0 and later only pass back Unicode characters to EditWordBreakProc. Thus, an ANSI application would convert the Rich Edit-supplied Unicode string using WideCharToMultiByte, and then translate the indices appropriately.EM_FINDWORDBREAKEM_SETWORDBREAKPROCEM_SETWORDBREAKPROCEXEditWordBreakProcExOther ResourcesReferenceSendMessage</param>

        public delegate int EDITWORDBREAKPROCW(string lpch, int ichCurrent, int cch, int code);

        /// <summary>
        ///The OutputProc function is an application-defined callback function used with the GrayString function. It is used to draw a string. The GRAYSTRINGPROC type defines a pointer to this callback function. OutputProc is a placeholder for the application-defined or library-defined function name.
        /// </summary>

        public delegate bool GRAYSTRINGPROC(nint unnamedParam1, nint unnamedParam2, int unnamedParam3);

        /// <summary>
        ///An application-defined or library-defined callback function used with the SetWindowsHookEx function. The system calls this function after the SendMessage function is called. The hook procedure can examine the message; it cannot modify it.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="wParam">Type: WPARAMSpecifies whether the message is sent by the current process. If the message is sent by the current process, it is nonzero; otherwise, it is NULL.</param>
        /// <param name="lParam">Type: LPARAMA pointer to a CWPRETSTRUCT structure that contains details about the message.Type: LRESULTIf nCode is less than zero, the hook procedure must return the value returned by CallNextHookEx function.If nCode is greater than or equal to zero, it is highly recommended that you call CallNextHookEx function and return the value it returns; otherwise, other applications that have installed WH_CALLWNDPROCRET hooks will not receive hook notifications and may behave incorrectly as a result. If the hook procedure does not call CallNextHookEx, the return value should be zero.An application installs the hook procedure by specifying the WH_CALLWNDPROCRET hook type and a pointer to the hook procedure in a call to the SetWindowsHookEx function.CWPRETSTRUCT structure, CallNextHookEx function, CallWindowProcW function, CallWindowProcA function, SendMessage, SetWindowsHookEx, Hooks</param>

        public delegate nint HOOKPROC(int code, nint wParam, nint lParam);

        /// <summary>
        ///A MonitorEnumProc function is an application-defined callback function that is called by the EnumDisplayMonitors function.
        /// </summary>

        public delegate bool MONITORENUMPROC(nint unnamedParam1, nint unnamedParam2, int unnamedParam3, nint unnamedParam4);

        /// <summary>
        ///A callback function, which you define in your application, that processes help events for the message box. The MSGBOXCALLBACK type defines a pointer to this callback function. The MsgBoxCallback name is a placeholder for the name of the function that you define in your application.
        /// </summary>

        public delegate void MSGBOXCALLBACK(nint lpHelpInfo);

        /// <summary>
        ///An application-defined callback function used with the EnumProps function. The function receives property entries from a window's property list. The PROPENUMPROC type defines a pointer to this callback function. PropEnumProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool PROPENUMPROCA(nint unnamedParam1, string unnamedParam2, nint unnamedParam3);

        /// <summary>
        ///Application-defined callback function used with the EnumPropsEx function. The function receives property entries from a window's property list. The PROPENUMPROCEX type defines a pointer to this callback function. PropEnumProcEx is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool PROPENUMPROCEXA(nint unnamedParam1, string unnamedParam2, nint unnamedParam3, int unnamedParam4);

        /// <summary>
        ///Application-defined callback function used with the EnumPropsEx function. The function receives property entries from a window's property list. The PROPENUMPROCEX type defines a pointer to this callback function. PropEnumProcEx is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool PROPENUMPROCEXW(nint unnamedParam1, string unnamedParam2, nint unnamedParam3, int unnamedParam4);

        /// <summary>
        ///An application-defined callback function used with the EnumProps function. The function receives property entries from a window's property list. The PROPENUMPROC type defines a pointer to this callback function. PropEnumProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool PROPENUMPROCW(nint unnamedParam1, string unnamedParam2, nint unnamedParam3);

        /// <summary>
        ///An application-defined callback function used with the SendMessageCallback function. The system passes the message to the callback function after passing the message to the destination window procedure. The SENDASYNCPROC type defines a pointer to this callback function. SendAsyncProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate void SENDASYNCPROC(nint unnamedParam1, uint unnamedParam2, int unnamedParam3, nint unnamedParam4);

        /// <summary>
        ///An application-defined callback function that processes WM_TIMER messages. The TIMERPROC type defines a pointer to this callback function. TimerProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate void TIMERPROC(nint unnamedParam1, uint unnamedParam2, int unnamedParam3, uint unnamedParam4);

        /// <summary>
        ///An application-defined callback (or hook) function that the system calls in response to events generated by an accessible object. The hook function processes the event notifications as required. Clients install the hook function and request specific types of event notifications by calling SetWinEventHook.
        /// </summary>

        public delegate void WINEVENTPROC(nint hWinEventHook, uint @event, nint hwnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);

        /// <summary>
        ///A callback function, which you define in your application, that processes messages sent to a window. The WNDPROC type defines a pointer to this callback function. The WndProc name is a placeholder for the name of the function that you define in your application.
        /// </summary>

        public delegate nint WNDPROC(nint unnamedParam1, uint unnamedParam2, nint unnamedParam3, nint unnamedParam4);
    }
}

