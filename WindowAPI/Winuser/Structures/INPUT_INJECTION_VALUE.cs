namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INPUT_INJECTION_VALUE
    {
        public ushort page;
        public ushort usage;
        public int value;
        public ushort index;
    }



}