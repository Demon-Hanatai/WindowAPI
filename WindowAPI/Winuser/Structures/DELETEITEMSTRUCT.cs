namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DELETEITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public nint hwndItem;
        public int itemData;
    }



}