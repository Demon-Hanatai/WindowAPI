
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POWERBROADCAST_SETTING
    {
        public IntPtr PowerSetting;
        public uint DataLength;
    }



}