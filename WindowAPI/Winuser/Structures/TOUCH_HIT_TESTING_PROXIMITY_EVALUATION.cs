
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCH_HIT_TESTING_PROXIMITY_EVALUATION
    {
        public IntPtr score;
        public IntPtr adjustedPoint;
    }



}