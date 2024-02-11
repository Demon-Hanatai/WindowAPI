using System.Runtime.InteropServices;


namespace WindowAPI.olecl.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PICTDESC
    {
        public uint cbSizeofstruct;
        public uint picType;
        public IntPtr hbitmap;
        public IntPtr hpal;
        public IntPtr hmeta;
        public uint xExt;
        public uint yExt;
        public IntPtr hicon;
        public IntPtr hemf;
    }



}