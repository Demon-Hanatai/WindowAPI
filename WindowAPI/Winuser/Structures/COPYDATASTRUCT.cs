namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COPYDATASTRUCT
    {
        public int dwData;
        public uint cbData;
        public nint lpData;
    }



}