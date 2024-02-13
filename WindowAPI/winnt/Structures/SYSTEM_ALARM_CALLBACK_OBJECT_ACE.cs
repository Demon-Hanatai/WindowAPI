namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_ALARM_CALLBACK_OBJECT_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public uint Flags;
        public int ObjectType;
        public int InheritedObjectType;
        public uint SidStart;
    }



}