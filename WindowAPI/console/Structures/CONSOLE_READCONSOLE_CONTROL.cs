namespace WindowAPI.console.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_READCONSOLE_CONTROL
    {
        public ulong nLength;
        public ulong nInitialChars;
        public ulong dwCtrlWakeupMask;
        public ulong dwControlKeyState;
    }


}