using System.Runtime.InteropServices;


namespace WindowAPI.olecl.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FONTDESC
    {
        public uint cbSizeofstruct;
        public IntPtr lpstrName;
        public IntPtr cySize;
        public short sWeight;
        public short sCharset;
        public bool fItalic;
        public bool fUnderline;
        public bool fStrikethrough;
    }



}