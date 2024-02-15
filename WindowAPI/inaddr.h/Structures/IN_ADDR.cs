namespace WindowAPI.inaddr.h.Structures
{
    [StructLayout(LayoutKind.Explicit)]

    public struct IN_ADDR
    {
        [FieldOffset(0)]
        public S_un _S_un;

        [StructLayout(LayoutKind.Explicit)]
        public struct S_un
        {
            [FieldOffset(0)]
            public S_un_b S_un_b;

            [FieldOffset(0)]
            public S_un_w S_un_w;

            [FieldOffset(0)]
            public uint S_addr;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct S_un_b
        {
            public byte s_b1;
            public byte s_b2;
            public byte s_b3;
            public byte s_b4;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct S_un_w
        {
            public ushort s_w1;
            public ushort s_w2;
        }
    }

}
