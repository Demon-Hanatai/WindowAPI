
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMPAREITEMSTRUCT
    {
        public IntPtr CtlType;
        public IntPtr CtlID;
        public IntPtr hwndItem;
        public IntPtr itemID1;
        public IntPtr itemData1;
        public IntPtr itemID2;
        public IntPtr itemData2;
        public uint dwLocaleId;
    }



}