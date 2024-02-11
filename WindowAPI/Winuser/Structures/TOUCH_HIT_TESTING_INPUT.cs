
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCH_HIT_TESTING_INPUT
    {
        public IntPtr pointerId;
        public IntPtr point;
        public IntPtr boundingBox;
        public IntPtr nonOccludedBoundingBox;
        public IntPtr orientation;
    }



}