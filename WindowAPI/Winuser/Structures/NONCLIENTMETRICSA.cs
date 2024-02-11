
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NONCLIENTMETRICSA
    {
        public IntPtr cbSize;
        public IntPtr iBorderWidth;
        public IntPtr iScrollWidth;
        public IntPtr iScrollHeight;
        public IntPtr iCaptionWidth;
        public IntPtr iCaptionHeight;
        public IntPtr lfCaptionFont;
        public IntPtr iSmCaptionWidth;
        public IntPtr iSmCaptionHeight;
        public IntPtr lfSmCaptionFont;
        public IntPtr iMenuWidth;
        public IntPtr iMenuHeight;
        public IntPtr lfMenuFont;
        public IntPtr lfStatusFont;
        public IntPtr lfMessageFont;
        public IntPtr iPaddedBorderWidth;
    }



}