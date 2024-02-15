namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HELPWININFOA
    {
        public int wStructSize;
        public int x;
        public int y;
        public int dx;
        public int dy;
        public int wMax;
        public char rgchMember;
    }



}