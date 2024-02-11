
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_CURSOR_INFO
    {
        public IntPtr cursorId;
        public IntPtr cursor;
    }



}