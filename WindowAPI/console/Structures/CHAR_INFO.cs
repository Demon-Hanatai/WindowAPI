namespace WindowAPI.console.Structures
{

    [StructLayout(LayoutKind.Sequential)]
    public struct CHAR_INFO
    {
        public CharUnion Char;
        public ushort Attributes;
    }

}