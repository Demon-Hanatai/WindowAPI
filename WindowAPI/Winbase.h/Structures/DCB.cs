namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DCB
    {
        public uint DCBlength;
        public uint BaudRate;
        public uint wReserved;
        public uint XonLim;
        public uint XoffLim;
        public int ByteSize;
        public int Parity;
        public int StopBits;
        public char XonChar;
        public char XoffChar;
        public char ErrorChar;
        public char EofChar;
        public char EvtChar;
        public uint wReserved1;
    }



}