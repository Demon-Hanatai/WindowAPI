namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TAPE_ERASE
    {
        public uint Type;
        public bool Immediate;
    }



}