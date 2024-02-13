namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY64
    {
        public uint Size;
        public uint TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public uint GlobalFlagsClear;
        public uint GlobalFlagsSet;
        public uint CriticalSectionDefaultTimeout;
        public int DeCommitFreeBlockThreshold;
        public int DeCommitTotalFreeThreshold;
        public int LockPrefixTable;
        public int MaximumAllocationSize;
        public int VirtualMemoryThreshold;
        public int ProcessAffinityMask;
        public uint ProcessHeapFlags;
        public short CSDVersion;
        public short DependentLoadFlags;
        public int EditList;
        public int SecurityCookie;
        public int SEHandlerTable;
        public int SEHandlerCount;
        public int GuardCFCheckFunctionPointer;
        public int GuardCFDispatchFunctionPointer;
        public int GuardCFFunctionTable;
        public int GuardCFFunctionCount;
        public uint GuardFlags;
        public int CodeIntegrity;
        public int GuardAddressTakenIatEntryTable;
        public int GuardAddressTakenIatEntryCount;
        public int GuardLongJumpTargetTable;
        public int GuardLongJumpTargetCount;
        public int DynamicValueRelocTable;
        public int CHPEMetadataPointer;
        public int GuardRFFailureRoutine;
        public int GuardRFFailureRoutineFunctionPointer;
        public uint DynamicValueRelocTableOffset;
        public short DynamicValueRelocTableSection;
        public short Reserved2;
        public int GuardRFVerifyStackPointerFunctionPointer;
        public uint HotPatchTableOffset;
        public uint Reserved3;
        public int EnclaveConfigurationPointer;
        public int VolatileMetadataPointer;
        public int GuardEHContinuationTable;
        public int GuardEHContinuationCount;
        public int GuardXFGCheckFunctionPointer;
        public int GuardXFGDispatchFunctionPointer;
        public int GuardXFGTableDispatchFunctionPointer;
        public int CastGuardOsDeterminedFailureMode;
        public int GuardMemcpyFunctionPointer;
    }



}