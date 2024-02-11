using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_STREAM_INFO
    {
        public uint NextEntryOffset;
        public uint StreamNameLength;
        public int StreamSize;
        public int StreamAllocationSize;
    }



}