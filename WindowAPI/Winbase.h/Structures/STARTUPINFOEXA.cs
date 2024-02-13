namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct STARTUPINFOEXA
    {
        public int StartupInfo;
        public IntPtr lpAttributeList;
    }



}