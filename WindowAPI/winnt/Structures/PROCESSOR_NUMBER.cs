namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESSOR_NUMBER
    {
        public short Group;
        public byte Number;
        public byte Reserved;
    }



}