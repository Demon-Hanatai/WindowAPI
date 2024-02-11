
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DRAWITEMSTRUCT
    {
        public IntPtr CtlType;
        public IntPtr CtlID;
        public IntPtr itemID;
        public IntPtr itemAction;
        public IntPtr itemState;
        public IntPtr hwndItem;
        public IntPtr hDC;
        public IntPtr rcItem;
        public IntPtr itemData;
    }



}