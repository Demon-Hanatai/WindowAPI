namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DELETEITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public IntPtr hwndItem;
        public int itemData;
    }



}