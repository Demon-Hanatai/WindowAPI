namespace WindowAPI.console.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO
    {
        public uint nFont;
        public COORD dwFontSize;
    }

}