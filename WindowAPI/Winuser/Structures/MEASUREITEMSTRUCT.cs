
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MEASUREITEMSTRUCT
    {
        public IntPtr CtlType;
        public IntPtr CtlID;
        public IntPtr itemID;
        public IntPtr itemWidth;
        public IntPtr itemHeight;
        public IntPtr itemData;
    }



}