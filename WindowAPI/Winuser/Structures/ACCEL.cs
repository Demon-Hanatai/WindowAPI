namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACCEL
    {
        public byte fVirt;
        public short key;
        public short cmd;
  
    }



}