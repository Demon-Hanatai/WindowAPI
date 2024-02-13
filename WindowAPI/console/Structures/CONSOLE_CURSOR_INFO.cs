namespace WindowAPI.console.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO
    {
        public uint dwSize;
        [MarshalAs(UnmanagedType.Bool)]
        public bool bVisible;
    }

}