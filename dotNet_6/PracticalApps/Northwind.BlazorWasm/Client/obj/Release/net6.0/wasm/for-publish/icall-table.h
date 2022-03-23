#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
186,
193,
194,
195,
196,
197,
198,
199,
200,
201,
204,
205,
367,
368,
370,
399,
400,
401,
421,
422,
423,
424,
425,
516,
517,
518,
521,
566,
567,
568,
571,
573,
575,
577,
582,
590,
591,
592,
593,
594,
595,
596,
597,
598,
599,
600,
601,
602,
603,
604,
605,
606,
607,
608,
610,
611,
612,
613,
614,
615,
616,
617,
713,
714,
715,
716,
717,
718,
719,
720,
721,
722,
723,
724,
725,
726,
727,
728,
729,
730,
731,
732,
733,
734,
735,
736,
737,
873,
874,
882,
885,
887,
893,
894,
896,
897,
901,
903,
905,
906,
907,
908,
910,
911,
912,
915,
916,
919,
920,
921,
996,
997,
999,
1007,
1008,
1009,
1010,
1011,
1015,
1016,
1017,
1018,
1019,
1020,
1022,
1023,
1024,
1026,
1027,
1029,
1033,
1034,
1035,
1308,
1528,
1529,
8439,
8440,
8442,
8443,
8444,
8445,
8446,
8447,
8449,
8451,
8453,
8454,
8455,
8463,
8465,
8469,
8470,
8472,
8474,
8476,
8489,
8498,
8499,
8501,
8502,
8503,
8504,
8505,
8507,
8509,
9547,
9551,
9553,
9554,
9555,
9556,
9635,
9636,
9637,
9638,
9659,
9660,
9661,
9662,
9664,
9666,
9708,
9759,
9762,
9772,
9773,
9774,
9775,
10185,
10186,
10191,
10192,
10244,
10245,
10246,
10273,
10279,
10286,
10296,
10300,
10392,
10402,
10403,
10416,
10417,
10418,
10419,
10420,
10421,
10422,
10429,
10445,
10466,
10467,
10476,
10478,
10485,
10486,
10489,
10491,
10496,
10502,
10503,
10510,
10512,
10522,
10525,
10526,
10527,
10538,
10550,
10556,
10557,
10558,
10560,
10561,
10571,
10590,
10612,
10613,
10614,
10615,
10616,
10633,
10640,
10671,
10672,
11189,
11190,
11273,
11354,
11617,
11618,
11627,
11628,
11629,
11635,
11713,
11888,
11889,
12574,
13832,
13851,
13858,
13859,
13861,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
int ves_icall_System_Enum_ToObject_raw (int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType_raw (int,int);
int ves_icall_System_Enum_get_underlying_type_raw (int,int);
int ves_icall_System_Enum_InternalHasFlag_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Abs_double (double);
float ves_icall_System_Math_Abs_single (float);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
int ves_icall_System_Math_ILogB (double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
int ves_icall_System_MathF_ILogB (float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_make_array_type_raw (int,int,int);
int ves_icall_RuntimeType_make_byref_type_raw (int,int);
int ves_icall_RuntimeType_MakePointerType_raw (int,int);
int ves_icall_RuntimeType_MakeGenericType_raw (int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetPacking_raw (int,int,int,int);
int ves_icall_System_Activator_CreateInstanceInternal_raw (int,int);
int ves_icall_RuntimeType_get_DeclaringMethod_raw (int,int);
int ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericArguments_raw (int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition_raw (int,int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetInterfaces_raw (int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_get_DeclaringType_raw (int,int);
int ves_icall_RuntimeType_get_Name_raw (int,int);
int ves_icall_RuntimeType_get_Namespace_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_HasInstantiation_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetModule_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsGenericVariable_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of (int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
int ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw (int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
void mono_digest_get_public_token (int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_System_Reflection_AssemblyName_ParseAssemblyName (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_EntryPoint_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_location_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_InternalImageRuntimeVersion_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
int ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
void ves_icall_Mono_RuntimeMarshal_FreeAssemblyName (int,int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 186,
ves_icall_System_Array_InternalCreate,
// token 193,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 194,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 195,
ves_icall_System_Array_CanChangePrimitive,
// token 196,
ves_icall_System_Array_FastCopy_raw,
// token 197,
ves_icall_System_Array_GetLength_raw,
// token 198,
ves_icall_System_Array_GetLowerBound_raw,
// token 199,
ves_icall_System_Array_GetGenericValue_icall,
// token 200,
ves_icall_System_Array_GetValueImpl_raw,
// token 201,
ves_icall_System_Array_SetGenericValue_icall,
// token 204,
ves_icall_System_Array_SetValueImpl_raw,
// token 205,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 367,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 368,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 370,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 399,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 400,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 401,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 421,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 422,
ves_icall_System_Enum_ToObject_raw,
// token 423,
ves_icall_System_Enum_InternalGetCorElementType_raw,
// token 424,
ves_icall_System_Enum_get_underlying_type_raw,
// token 425,
ves_icall_System_Enum_InternalHasFlag_raw,
// token 516,
ves_icall_System_Environment_get_ProcessorCount,
// token 517,
ves_icall_System_Environment_get_TickCount,
// token 518,
ves_icall_System_Environment_get_TickCount64,
// token 521,
ves_icall_System_Environment_FailFast_raw,
// token 566,
ves_icall_System_GC_GetCollectionCount,
// token 567,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 568,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 571,
ves_icall_System_GC_SuppressFinalize_raw,
// token 573,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 575,
ves_icall_System_GC_GetGCMemoryInfo,
// token 577,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 582,
ves_icall_System_Object_MemberwiseClone_raw,
// token 590,
ves_icall_System_Math_Abs_double,
// token 591,
ves_icall_System_Math_Abs_single,
// token 592,
ves_icall_System_Math_Acos,
// token 593,
ves_icall_System_Math_Acosh,
// token 594,
ves_icall_System_Math_Asin,
// token 595,
ves_icall_System_Math_Asinh,
// token 596,
ves_icall_System_Math_Atan,
// token 597,
ves_icall_System_Math_Atan2,
// token 598,
ves_icall_System_Math_Atanh,
// token 599,
ves_icall_System_Math_Cbrt,
// token 600,
ves_icall_System_Math_Ceiling,
// token 601,
ves_icall_System_Math_Cos,
// token 602,
ves_icall_System_Math_Cosh,
// token 603,
ves_icall_System_Math_Exp,
// token 604,
ves_icall_System_Math_Floor,
// token 605,
ves_icall_System_Math_Log,
// token 606,
ves_icall_System_Math_Log10,
// token 607,
ves_icall_System_Math_Pow,
// token 608,
ves_icall_System_Math_Sin,
// token 610,
ves_icall_System_Math_Sinh,
// token 611,
ves_icall_System_Math_Sqrt,
// token 612,
ves_icall_System_Math_Tan,
// token 613,
ves_icall_System_Math_Tanh,
// token 614,
ves_icall_System_Math_FusedMultiplyAdd,
// token 615,
ves_icall_System_Math_ILogB,
// token 616,
ves_icall_System_Math_Log2,
// token 617,
ves_icall_System_Math_ModF,
// token 713,
ves_icall_System_MathF_Acos,
// token 714,
ves_icall_System_MathF_Acosh,
// token 715,
ves_icall_System_MathF_Asin,
// token 716,
ves_icall_System_MathF_Asinh,
// token 717,
ves_icall_System_MathF_Atan,
// token 718,
ves_icall_System_MathF_Atan2,
// token 719,
ves_icall_System_MathF_Atanh,
// token 720,
ves_icall_System_MathF_Cbrt,
// token 721,
ves_icall_System_MathF_Ceiling,
// token 722,
ves_icall_System_MathF_Cos,
// token 723,
ves_icall_System_MathF_Cosh,
// token 724,
ves_icall_System_MathF_Exp,
// token 725,
ves_icall_System_MathF_Floor,
// token 726,
ves_icall_System_MathF_Log,
// token 727,
ves_icall_System_MathF_Log10,
// token 728,
ves_icall_System_MathF_Pow,
// token 729,
ves_icall_System_MathF_Sin,
// token 730,
ves_icall_System_MathF_Sinh,
// token 731,
ves_icall_System_MathF_Sqrt,
// token 732,
ves_icall_System_MathF_Tan,
// token 733,
ves_icall_System_MathF_Tanh,
// token 734,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 735,
ves_icall_System_MathF_ILogB,
// token 736,
ves_icall_System_MathF_Log2,
// token 737,
ves_icall_System_MathF_ModF,
// token 873,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 874,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 882,
ves_icall_RuntimeType_make_array_type_raw,
// token 885,
ves_icall_RuntimeType_make_byref_type_raw,
// token 887,
ves_icall_RuntimeType_MakePointerType_raw,
// token 893,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 894,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 896,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 897,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 901,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 903,
ves_icall_RuntimeType_GetPacking_raw,
// token 905,
ves_icall_System_Activator_CreateInstanceInternal_raw,
// token 906,
ves_icall_RuntimeType_get_DeclaringMethod_raw,
// token 907,
ves_icall_System_RuntimeType_getFullName_raw,
// token 908,
ves_icall_RuntimeType_GetGenericArguments_raw,
// token 910,
ves_icall_RuntimeType_GetGenericParameterPosition_raw,
// token 911,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 912,
ves_icall_RuntimeType_GetFields_native_raw,
// token 915,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 916,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 919,
ves_icall_RuntimeType_get_DeclaringType_raw,
// token 920,
ves_icall_RuntimeType_get_Name_raw,
// token 921,
ves_icall_RuntimeType_get_Namespace_raw,
// token 996,
ves_icall_RuntimeTypeHandle_GetAttributes_raw,
// token 997,
ves_icall_reflection_get_token_raw,
// token 999,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1007,
ves_icall_RuntimeTypeHandle_GetCorElementType_raw,
// token 1008,
ves_icall_RuntimeTypeHandle_HasInstantiation_raw,
// token 1009,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1010,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1011,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1015,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1016,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1017,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1018,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1019,
ves_icall_RuntimeTypeHandle_IsGenericVariable_raw,
// token 1020,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1022,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1023,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw,
// token 1024,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1026,
ves_icall_RuntimeTypeHandle_is_subclass_of,
// token 1027,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1029,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1033,
ves_icall_System_String_FastAllocateString_raw,
// token 1034,
ves_icall_System_String_InternalIsInterned_raw,
// token 1035,
ves_icall_System_String_InternalIntern_raw,
// token 1308,
ves_icall_System_Type_internal_from_handle_raw,
// token 1528,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1529,
ves_icall_System_ValueType_Equals_raw,
// token 8439,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8440,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8442,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8443,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 8444,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8445,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8446,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8447,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8449,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8451,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8453,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8454,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8455,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 8463,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8465,
mono_monitor_exit_icall_raw,
// token 8469,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 8470,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8472,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8474,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8476,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8489,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 8498,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8499,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8501,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8502,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8503,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8504,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8505,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8507,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8509,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 9547,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 9551,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 9553,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 9554,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 9555,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 9556,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 9635,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 9636,
ves_icall_System_GCHandle_InternalFree_raw,
// token 9637,
ves_icall_System_GCHandle_InternalGet_raw,
// token 9638,
ves_icall_System_GCHandle_InternalSet_raw,
// token 9659,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 9660,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 9661,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 9662,
ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw,
// token 9664,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw,
// token 9666,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 9708,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 9759,
mono_object_hash_icall_raw,
// token 9762,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 9772,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 9773,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 9774,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 9775,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 10185,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 10186,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 10191,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 10192,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 10244,
mono_digest_get_public_token,
// token 10245,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 10246,
ves_icall_System_Reflection_AssemblyName_ParseAssemblyName,
// token 10273,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 10279,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 10286,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10296,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10300,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 10392,
ves_icall_System_Reflection_RuntimeAssembly_get_EntryPoint_raw,
// token 10402,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 10403,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 10416,
ves_icall_System_Reflection_RuntimeAssembly_get_location_raw,
// token 10417,
ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw,
// token 10418,
ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw,
// token 10419,
ves_icall_System_Reflection_RuntimeAssembly_InternalImageRuntimeVersion_raw,
// token 10420,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 10421,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 10422,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 10429,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 10445,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 10466,
ves_icall_reflection_get_token_raw,
// token 10467,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 10476,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 10478,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 10485,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 10486,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 10489,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 10491,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 10496,
ves_icall_reflection_get_token_raw,
// token 10502,
ves_icall_get_method_info_raw,
// token 10503,
ves_icall_get_method_attributes,
// token 10510,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 10512,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 10522,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 10525,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 10526,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 10527,
ves_icall_reflection_get_token_raw,
// token 10538,
ves_icall_InternalInvoke_raw,
// token 10550,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 10556,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 10557,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 10558,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 10560,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 10561,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 10571,
ves_icall_InternalInvoke_raw,
// token 10590,
ves_icall_reflection_get_token_raw,
// token 10612,
ves_icall_reflection_get_token_raw,
// token 10613,
ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw,
// token 10614,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 10615,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 10616,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 10633,
ves_icall_reflection_get_token_raw,
// token 10640,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 10671,
ves_icall_reflection_get_token_raw,
// token 10672,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 11189,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 11190,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 11273,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 11354,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 11617,
ves_icall_ModuleBuilder_basic_init_raw,
// token 11618,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 11627,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 11628,
ves_icall_ModuleBuilder_getToken_raw,
// token 11629,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 11635,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 11713,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 11888,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 11889,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 12574,
ves_icall_System_Diagnostics_Debugger_Log,
// token 13832,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 13851,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 13858,
ves_icall_Mono_RuntimeMarshal_FreeAssemblyName,
// token 13859,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 13861,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
1,
0,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
};
