using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTCTX_SECTION_KEYED_DATA
    {
        public int cbSize;
        public int ulDataFormatVersion;
        public IntPtr lpData;
        public int ulLength;
        public IntPtr lpSectionGlobalData;
        public int ulSectionGlobalDataLength;
        public IntPtr lpSectionBase;
        public int ulSectionTotalLength;
        public IntPtr hActCtx;
        public int ulAssemblyRosterIndex;
        public int ulFlags;
        public int AssemblyMetadata;
    }



}