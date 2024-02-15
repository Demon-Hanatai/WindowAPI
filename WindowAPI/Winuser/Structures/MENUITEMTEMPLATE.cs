namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUITEMTEMPLATE
    {
        public short mtOption;
        public short mtID;
        public StringBuilder mtString;
    }



}