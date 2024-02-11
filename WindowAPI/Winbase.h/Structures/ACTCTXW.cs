using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTCTXW
    {
        public int cbSize;
        public uint dwFlags;
        public string lpSource;
        public short wProcessorArchitecture;
        public ushort wLangId;
        public string lpAssemblyDirectory;
        public string lpResourceName;
        public string lpApplicationName;
        public IntPtr hModule;
    }



}