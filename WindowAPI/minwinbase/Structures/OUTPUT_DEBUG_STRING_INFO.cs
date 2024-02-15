namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        public string lpDebugStringData;
        public short fUnicode;
        public short nDebugStringLength;
    }



}