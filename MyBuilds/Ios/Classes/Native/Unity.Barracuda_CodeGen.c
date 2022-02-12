#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void Unity.Barracuda.CSharpBLAS::.ctor()
extern void CSharpBLAS__ctor_m9F5E7882BD50B10EA237DFB48C5A02B8C9127F63 (void);
// 0x00000002 System.Void Unity.Barracuda.CSharpBLAS/SGEMMJob::Execute()
extern void SGEMMJob_Execute_m53B32DF4D1F9A391106FC27F66868316EA0E7D99 (void);
// 0x00000003 System.Void Unity.Barracuda.MatrixUtils::CopyBlockWithPadding(System.Single*,System.Int32,System.Int32,System.Int32,System.Int32,System.Single[],System.Int32,System.Boolean)
extern void MatrixUtils_CopyBlockWithPadding_mC8A56F4BBAEA371D3D79761C2532AC1FC6B7F34D (void);
// 0x00000004 System.Void Unity.Barracuda.MatrixUtils::CopyBlockWithPadding(System.Single[],System.Single*,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
extern void MatrixUtils_CopyBlockWithPadding_m1CD12087B35363D101CD5A6BC5FE8C6CE6434B51 (void);
// 0x00000005 System.Void Unity.Barracuda.MatrixUtils::MultiplyBlockUnroll8xhPadded(System.Single*,System.Single*,System.Single*,System.Int32)
extern void MatrixUtils_MultiplyBlockUnroll8xhPadded_m840E7A0AC8B7C039D1E75E5A5239CB75DF768D72 (void);
// 0x00000006 System.Void Unity.Barracuda.MatrixUtils::MultiplyBlockUnroll8xhParallelWithPadding(System.Single*,System.Int32,System.Int32,System.Single*,System.Int32,System.Int32,System.Single*,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean)
extern void MatrixUtils_MultiplyBlockUnroll8xhParallelWithPadding_m34CA82F582B5138ACB17B171D81E8C0156140FBA (void);
// 0x00000007 System.Void Unity.Barracuda.MatrixUtils/<>c__DisplayClass7_0::.ctor()
extern void U3CU3Ec__DisplayClass7_0__ctor_mD79C926F24C4A67247037920166564174A3EE2AE (void);
// 0x00000008 System.Void Unity.Barracuda.MatrixUtils/<>c__DisplayClass7_0::<MultiplyBlockUnroll8xhParallelWithPadding>b__0(System.Int32)
extern void U3CU3Ec__DisplayClass7_0_U3CMultiplyBlockUnroll8xhParallelWithPaddingU3Eb__0_m94BEC7B52C407A729FFC223A9A63AA56EFA2E437 (void);
static Il2CppMethodPointer s_methodPointers[8] = 
{
	CSharpBLAS__ctor_m9F5E7882BD50B10EA237DFB48C5A02B8C9127F63,
	SGEMMJob_Execute_m53B32DF4D1F9A391106FC27F66868316EA0E7D99,
	MatrixUtils_CopyBlockWithPadding_mC8A56F4BBAEA371D3D79761C2532AC1FC6B7F34D,
	MatrixUtils_CopyBlockWithPadding_m1CD12087B35363D101CD5A6BC5FE8C6CE6434B51,
	MatrixUtils_MultiplyBlockUnroll8xhPadded_m840E7A0AC8B7C039D1E75E5A5239CB75DF768D72,
	MatrixUtils_MultiplyBlockUnroll8xhParallelWithPadding_m34CA82F582B5138ACB17B171D81E8C0156140FBA,
	U3CU3Ec__DisplayClass7_0__ctor_mD79C926F24C4A67247037920166564174A3EE2AE,
	U3CU3Ec__DisplayClass7_0_U3CMultiplyBlockUnroll8xhParallelWithPaddingU3Eb__0_m94BEC7B52C407A729FFC223A9A63AA56EFA2E437,
};
extern void SGEMMJob_Execute_m53B32DF4D1F9A391106FC27F66868316EA0E7D99_AdjustorThunk (void);
static Il2CppTokenAdjustorThunkPair s_adjustorThunks[1] = 
{
	{ 0x06000002, SGEMMJob_Execute_m53B32DF4D1F9A391106FC27F66868316EA0E7D99_AdjustorThunk },
};
static const int32_t s_InvokerIndices[8] = 
{
	4625,
	4625,
	4802,
	4837,
	5480,
	4748,
	4625,
	3662,
};
extern const CustomAttributesCacheGenerator g_Unity_Barracuda_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Unity_Barracuda_CodeGenModule;
const Il2CppCodeGenModule g_Unity_Barracuda_CodeGenModule = 
{
	"Unity.Barracuda.dll",
	8,
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
	g_Unity_Barracuda_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
