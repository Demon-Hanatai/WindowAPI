namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DOCINFOW
    {
        public int cbSize;
        public string lpszDocName;
        public string lpszOutput;
        public string lpszDatatype;
        public uint fwType;
    }



}