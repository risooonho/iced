/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_INSTR_INFO
namespace Iced.Intel.InstructionInfoInternal {
	enum CpuidFeatureInternal {
		INTEL8086,
		INTEL8086_ONLY,
		INTEL186,
		INTEL286,
		INTEL286_ONLY,
		INTEL386,
		INTEL386_ONLY,
		INTEL386_A0_ONLY,
		INTEL486,
		INTEL486_A_ONLY,
		INTEL386_486_ONLY,
		IA64,
		X64,
		ADX,
		AES,
		AES_and_AVX,
		AVX,
		AVX_and_GFNI,
		AVX2,
		AVX512_4FMAPS,
		AVX512_4VNNIW,
		AVX512_BITALG,
		AVX512_IFMA,
		AVX512_VBMI,
		AVX512_VBMI2,
		AVX512_VNNI,
		AVX512_VPOPCNTDQ,
		AVX512BW,
		AVX512CD,
		AVX512DQ,
		AVX512ER,
		AVX512F,
		AVX512F_and_GFNI,
		AVX512F_and_VAES,
		AVX512F_and_VPCLMULQDQ,
		AVX512PF,
		AVX512VL_and_AVX512_BF16,
		AVX512VL_and_AVX512_BITALG,
		AVX512VL_and_AVX512_IFMA,
		AVX512VL_and_AVX512_VBMI,
		AVX512VL_and_AVX512_VBMI2,
		AVX512VL_and_AVX512_VNNI,
		AVX512VL_and_AVX512_VPOPCNTDQ,
		AVX512VL_and_AVX512BW,
		AVX512VL_and_AVX512CD,
		AVX512VL_and_AVX512DQ,
		AVX512VL_and_AVX512F,
		AVX512VL_and_GFNI,
		AVX512VL_and_VAES,
		AVX512VL_and_VPCLMULQDQ,
		BMI1,
		BMI2,
		CET_IBT,
		CET_SS,
		CFLSH,
		CL1INVMB,
		CLDEMOTE,
		CLFLUSHOPT,
		CLFSH,
		CLWB,
		CLZERO,
		CMOV,
		CMPXCHG16B,
		CPUID,
		CX8,
		D3NOW,
		D3NOWEXT,
		ECR,
		ENCLV,
		F16C,
		FMA,
		FMA4,
		FPU,
		FPU_and_CMOV,
		FPU_and_SSE3,
		FPU287,
		FPU287XL_ONLY,
		FPU387,
		FPU387SL_ONLY,
		FSGSBASE,
		FXSR,
		GEODE,
		GFNI,
		HLE_or_RTM,
		INVEPT,
		INVPCID,
		INVVPID,
		LWP,
		LZCNT,
		MMX,
		MONITOR,
		MONITORX,
		MOVBE,
		MOVDIR64B,
		MOVDIRI,
		MPX,
		MSR,
		MULTIBYTENOP,
		PADLOCK_ACE,
		PADLOCK_PHE,
		PADLOCK_PMM,
		PADLOCK_RNG,
		PAUSE,
		PCLMULQDQ,
		PCLMULQDQ_and_AVX,
		PCOMMIT,
		PCONFIG,
		PKU,
		POPCNT,
		PREFETCHW,
		PREFETCHWT1,
		PTWRITE,
		RDPID,
		RDPMC,
		RDRAND,
		RDSEED,
		RDTSCP,
		RTM,
		SEP,
		SGX1,
		SHA,
		SKINIT_or_SVML,
		SMAP,
		SMX,
		SSE,
		SSE2,
		SSE3,
		SSE4_1,
		SSE4_2,
		SSE4A,
		SSSE3,
		SVM,
		SYSCALL,
		TBM,
		TSC,
		VAES,
		VMX,
		VPCLMULQDQ,
		WAITPKG,
		WBNOINVD,
		XOP,
		XSAVE,
		XSAVEC,
		XSAVEOPT,
		XSAVES,
		ZALLOC,
		// If a new value is added, update InfoFlags2.CpuidFeatureMask if needed
	}
}
#endif
