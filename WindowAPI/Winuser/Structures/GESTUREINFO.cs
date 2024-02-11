
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GESTUREINFO
    {
        public IntPtr cbSize;
        public uint dwFlags;
        public uint dwID;
        public IntPtr hwndTarget;
        public IntPtr ptsLocation;
        public uint dwInstanceID;
        public uint dwSequenceID;
        public IntPtr ullArguments;
        public IntPtr cbExtraArgs;
    }



}