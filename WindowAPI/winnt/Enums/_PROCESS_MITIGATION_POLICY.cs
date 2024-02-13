namespace WindowAPI.winnt.Enums
{


    public enum _PROCESS_MITIGATION_POLICY
    {
        ProcessDEPPolicy,
        ProcessASLRPolicy,
        ProcessDynamicCodePolicy,
        ProcessStrictHandleCheckPolicy,
        ProcessSystemCallDisablePolicy,
        ProcessMitigationOptionsMask,
        ProcessExtensionPointDisablePolicy,
        ProcessControlFlowGuardPolicy,
        ProcessSignaturePolicy,
        ProcessFontDisablePolicy,
        ProcessImageLoadPolicy,
        ProcessSystemCallFilterPolicy,
        ProcessPayloadRestrictionPolicy,
        ProcessChildProcessPolicy,
        ProcessSideChannelIsolationPolicy,
        ProcessUserShadowStackPolicy,
        ProcessRedirectionTrustPolicy,
        ProcessUserPointerAuthPolicy,
        ProcessSEHOPPolicy,
        MaxProcessMitigationPolicy
    }



}

