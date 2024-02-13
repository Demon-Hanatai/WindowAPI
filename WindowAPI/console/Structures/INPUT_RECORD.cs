namespace WindowAPI.console.Structures
{
    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT_RECORD
    {
        [FieldOffset(0)]
        public ushort EventType;
        [FieldOffset(4)]
        public KEY_EVENT_RECORD KeyEvent;
        [FieldOffset(4)]
        public MOUSE_EVENT_RECORD MouseEvent;
        // Additional event records like WINDOW_BUFFER_SIZE_RECORD, MENU_EVENT_RECORD, etc., can be added similarly
    }

}