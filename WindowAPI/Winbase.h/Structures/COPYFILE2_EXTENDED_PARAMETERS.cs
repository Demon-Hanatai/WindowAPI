using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COPYFILE2_EXTENDED_PARAMETERS
    {
        public uint dwSize;
        public uint dwCopyFlags;
        public int pProgressRoutine;
        public IntPtr pvCallbackContext;
    }



}