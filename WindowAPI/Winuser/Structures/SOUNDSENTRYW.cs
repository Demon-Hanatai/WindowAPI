namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOUNDSENTRYW
    {
        public uint cbSize;
        public uint dwFlags;
        public uint iFSTextEffect;
        public uint iFSTextEffectMSec;
        public uint iFSTextEffectColorBits;
        public uint iFSGrafEffect;
        public uint iFSGrafEffectMSec;
        public uint iFSGrafEffectColor;
        public uint iWindowsEffect;
        public uint iWindowsEffectMSec;
        public string lpszWindowsEffectDLL;
        public uint iWindowsEffectOrdinal;
    }



}