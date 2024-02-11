using System.Runtime.InteropServices;


namespace WindowAPI.olecl.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OCPFIPARAMS
    {
        public uint cbStructSize;
        public IntPtr hWndOwner;
        public uint x;
        public uint y;
        public IntPtr lpszCaption;
        public uint cObjects;
        public uint cPages;
        public IntPtr lcid;
        public IntPtr dispidInitialProperty;
    }



}