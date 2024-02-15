namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCH_HIT_TESTING_PROXIMITY_EVALUATION
    {
        public int score;
        public POINT adjustedPoint;
    }



}