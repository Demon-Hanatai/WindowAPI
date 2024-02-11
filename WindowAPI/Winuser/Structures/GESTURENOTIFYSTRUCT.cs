
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GESTURENOTIFYSTRUCT
    {
        public IntPtr cbSize;
        public uint dwFlags;
        public IntPtr hwndTarget;
        public IntPtr ptsLocation;
        public uint dwInstanceID;
    }



}