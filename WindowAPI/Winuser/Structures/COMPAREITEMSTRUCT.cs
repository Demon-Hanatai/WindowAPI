namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMPAREITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public nint hwndItem;
        public uint itemID1;
        public int itemData1;
        public uint itemID2;
        public int itemData2;
        public uint dwLocaleId;
    }



}