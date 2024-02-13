namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HELPWININFOW
    {
        public int wStructSize;
        public int x;
        public int y;
        public int dx;
        public int dy;
        public int wMax;
        public StringBuilder rgchMember;
    }



}