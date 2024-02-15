namespace WindowAPI.winreg.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct VALENTA
    {
        public string ve_valuename;
        public uint ve_valuelen;
        public uint ve_valueptr;
        public uint ve_type;
    }



}