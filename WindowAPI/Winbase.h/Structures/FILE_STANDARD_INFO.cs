using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_STANDARD_INFO
    {
        public int AllocationSize;
        public int EndOfFile;
        public uint NumberOfLinks;
        public bool DeletePending;
        public bool Directory;
    }



}