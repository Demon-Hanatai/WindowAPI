
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DELETEITEMSTRUCT
    {
        public IntPtr CtlType;
        public IntPtr CtlID;
        public IntPtr itemID;
        public IntPtr hwndItem;
        public IntPtr itemData;
    }



}