
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INPUT_MESSAGE_SOURCE
    {
        public IntPtr deviceType;
        public IntPtr originId;
    }



}