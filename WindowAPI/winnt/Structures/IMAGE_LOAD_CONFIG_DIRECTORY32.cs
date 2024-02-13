namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY32
    {
        public uint Size;
        public uint TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public uint GlobalFlagsClear;
        public uint GlobalFlagsSet;
        public uint CriticalSectionDefaultTimeout;
        public uint DeCommitFreeBlockThreshold;
        public uint DeCommitTotalFreeThreshold;
        public uint LockPrefixTable;
        public uint MaximumAllocationSize;
        public uint VirtualMemoryThreshold;
        public uint ProcessHeapFlags;
        public uint ProcessAffinityMask;
        public short CSDVersion;
        public short DependentLoadFlags;
        public uint EditList;
        public uint SecurityCookie;
        public uint SEHandlerTable;
        public uint SEHandlerCount;
        public uint GuardCFCheckFunctionPointer;
        public uint GuardCFDispatchFunctionPointer;
        public uint GuardCFFunctionTable;
        public uint GuardCFFunctionCount;
        public uint GuardFlags;
        public int CodeIntegrity;
        public uint GuardAddressTakenIatEntryTable;
        public uint GuardAddressTakenIatEntryCount;
        public uint GuardLongJumpTargetTable;
        public uint GuardLongJumpTargetCount;
        public uint DynamicValueRelocTable;
        public uint CHPEMetadataPointer;
        public uint GuardRFFailureRoutine;
        public uint GuardRFFailureRoutineFunctionPointer;
        public uint DynamicValueRelocTableOffset;
        public short DynamicValueRelocTableSection;
        public short Reserved2;
        public uint GuardRFVerifyStackPointerFunctionPointer;
        public uint HotPatchTableOffset;
        public uint Reserved3;
        public uint EnclaveConfigurationPointer;
        public uint VolatileMetadataPointer;
        public uint GuardEHContinuationTable;
        public uint GuardEHContinuationCount;
        public uint GuardXFGCheckFunctionPointer;
        public uint GuardXFGDispatchFunctionPointer;
        public uint GuardXFGTableDispatchFunctionPointer;
        public uint CastGuardOsDeterminedFailureMode;
        public uint GuardMemcpyFunctionPointer;
    }



}