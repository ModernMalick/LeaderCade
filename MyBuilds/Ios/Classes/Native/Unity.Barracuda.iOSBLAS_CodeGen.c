#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void Unity.Barracuda.iOSBLAS::iossgemm(System.Single*,System.Int32,System.Int32,System.Single*,System.Int32,System.Int32,System.Single*,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean)
extern void iOSBLAS_iossgemm_mEFFCA8ABE3580EB653730A4E6A755531D90AF9FE (void);
// 0x00000002 System.Void Unity.Barracuda.iOSBLAS::.ctor()
extern void iOSBLAS__ctor_m1A437D01753D6D188DFAE7BC2D23B154F47B3368 (void);
// 0x00000003 System.Void Unity.Barracuda.iOSBLAS/SGEMMJob::Execute()
extern void SGEMMJob_Execute_m5C3EABF8F7B934CAB71C349C178CF45F8CE4E2A4 (void);
static Il2CppMethodPointer s_methodPointers[3] = 
{
	iOSBLAS_iossgemm_mEFFCA8ABE3580EB653730A4E6A755531D90AF9FE,
	iOSBLAS__ctor_m1A437D01753D6D188DFAE7BC2D23B154F47B3368,
	SGEMMJob_Execute_m5C3EABF8F7B934CAB71C349C178CF45F8CE4E2A4,
};
extern void SGEMMJob_Execute_m5C3EABF8F7B934CAB71C349C178CF45F8CE4E2A4_AdjustorThunk (void);
static Il2CppTokenAdjustorThunkPair s_adjustorThunks[1] = 
{
	{ 0x06000003, SGEMMJob_Execute_m5C3EABF8F7B934CAB71C349C178CF45F8CE4E2A4_AdjustorThunk },
};
static const int32_t s_InvokerIndices[3] = 
{
	4781,
	4653,
	4653,
};
extern const CustomAttributesCacheGenerator g_Unity_Barracuda_iOSBLAS_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Unity_Barracuda_iOSBLAS_CodeGenModule;
const Il2CppCodeGenModule g_Unity_Barracuda_iOSBLAS_CodeGenModule = 
{
	"Unity.Barracuda.iOSBLAS.dll",
	3,
	s_methodPointers,
	1,
	s_adjustorThunks,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	g_Unity_Barracuda_iOSBLAS_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
