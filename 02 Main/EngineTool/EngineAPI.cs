using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace HalconDotNet
{
	[SuppressUnmanagedCodeSecurity]
	internal class EngineAPI
	{
		private const string EngineDLL = "hdevenginecpp";

		private const CallingConvention EngineCall = CallingConvention.Cdecl;

		internal const int H_MSG_OK = 2;

		internal const int H_MSG_TRUE = 2;

		internal const int H_MSG_FALSE = 3;

		internal const int H_MSG_VOID = 4;

		internal const int H_MSG_FAIL = 5;

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateEngine")]
		internal static extern int CreateEngine(out IntPtr engine);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyEngine")]
		internal static extern int DestroyEngine(IntPtr engine);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetEngineAttribute")]
		internal static extern int SetEngineAttribute(IntPtr engine, string name, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetEngineAttribute")]
		internal static extern int GetEngineAttribute(IntPtr engine, string name, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenStartDebugServer")]
		internal static extern int StartDebugServer(IntPtr engine);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenStopDebugServer")]
		internal static extern int StopDebugServer(IntPtr engine);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int HCenSetProcedurePath(IntPtr engine, IntPtr path_utf8);

		internal static int SetProcedurePath(IntPtr engine, string path)
		{
			IntPtr intPtr = HalconAPI.ToHGlobalUtf8Encoding(path);
			int result = EngineAPI.HCenSetProcedurePath(engine, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int HCenAddProcedurePath(IntPtr engine, IntPtr path_utf8);

		internal static int AddProcedurePath(IntPtr engine, string path)
		{
			IntPtr intPtr = HalconAPI.ToHGlobalUtf8Encoding(path);
			int result = EngineAPI.HCenAddProcedurePath(engine, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetHDevOperatorImpl")]
		internal static extern int SetHDevOperatorImpl(IntPtr engine, IntPtr implementation);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetProcedureNames")]
		internal static extern int GetProcedureNames(IntPtr engine, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetLoadedProcedureNames")]
		internal static extern int GetLoadedProcedureNames(IntPtr engine, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenUnloadProcedure")]
		internal static extern int UnloadProcedure(IntPtr engine, string name);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenUnloadAllProcedures")]
		internal static extern int UnloadAllProcedures(IntPtr engine);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalIconicVarNames")]
		internal static extern int GetGlobalIconicVarNames(IntPtr engine, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalCtrlVarNames")]
		internal static extern int GetGlobalCtrlVarNames(IntPtr engine, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalCtrlVarDimension")]
		internal static extern int GetGlobalCtrlVarDimension(IntPtr engine, string name, out int dimension);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalIconicVarDimension")]
		internal static extern int GetGlobalIconicVarDimension(IntPtr engine, string name, out int dimension);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalCtrlVarTuple")]
		internal static extern int GetGlobalCtrlVarTuple(IntPtr engine, string name, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalCtrlVarVector")]
		internal static extern int GetGlobalCtrlVarVector(IntPtr engine, string name, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalIconicVarObject")]
		internal static extern int GetGlobalIconicVarObject(IntPtr engine, string name, out IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetGlobalIconicVarVector")]
		internal static extern int GetGlobalIconicVarVector(IntPtr engine, string name, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetGlobalCtrlVarTuple")]
		internal static extern int SetGlobalCtrlVarTuple(IntPtr engine, string name, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetGlobalCtrlVarVector")]
		internal static extern int SetGlobalCtrlVarVector(IntPtr engine, string name, IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetGlobalIconicVarObject")]
		internal static extern int SetGlobalIconicVarObject(IntPtr engine, string name, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetGlobalIconicVarVector")]
		internal static extern int SetGlobalIconicVarVector(IntPtr engine, string name, IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateProgram")]
		internal static extern int CreateProgram(out IntPtr program);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyProgram")]
		internal static extern int DestroyProgram(IntPtr program);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int HCenLoadProgram(IntPtr program, IntPtr fileName);

		internal static int LoadProgram(IntPtr program, string fileName)
		{
			IntPtr intPtr = HalconAPI.ToHGlobalUtf8Encoding(fileName);
			int result = EngineAPI.HCenLoadProgram(program, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		private static extern int HCenGetProgramInfo(IntPtr program, out IntPtr name, out bool loaded, IntPtr varNamesIconic, IntPtr varNamesCtrl, IntPtr varDimsIconic, IntPtr varDimsCtrl);

		internal static void GetProgramInfo(IntPtr program, out string name, out bool loaded, out HTuple varNamesIconic, out HTuple varNamesCtrl, out HTuple varDimsIconic, out HTuple varDimsCtrl)
		{
			IntPtr intPtr;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr));
			IntPtr intPtr2;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr2));
			IntPtr intPtr3;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr3));
			IntPtr intPtr4;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr4));
			IntPtr intPtr5;
			EngineAPI.HCkE(EngineAPI.HCenGetProgramInfo(program, out intPtr5, out loaded, intPtr, intPtr2, intPtr3, intPtr4));
			name = Marshal.PtrToStringAnsi(intPtr5);
			varNamesIconic = HalconAPI.LoadTuple(intPtr);
			varNamesCtrl = HalconAPI.LoadTuple(intPtr2);
			varDimsIconic = HalconAPI.LoadTuple(intPtr3);
			varDimsCtrl = HalconAPI.LoadTuple(intPtr4);
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProgGetUsedProcedureNames")]
		internal static extern int GetUsedProcedureNamesForProgram(IntPtr program, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProgGetLocalProcedureNames")]
		internal static extern int GetLocalProcedureNames(IntPtr program, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProgCompileUsedProcedures")]
		internal static extern int CompileUsedProceduresForProgram(IntPtr program, out bool ret);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateProgramCall")]
		internal static extern int CreateProgramCall(IntPtr program, out IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyProgramCall")]
		internal static extern int DestroyProgramCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenExecuteProgramCall")]
		internal static extern int ExecuteProgramCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetWaitForDebugConnectionProgramCall")]
		internal static extern int SetWaitForDebugConnectionProgramCall(IntPtr call, bool wait_once);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenResetProgramCall")]
		internal static extern int ResetProgramCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetCtrlVarTupleIndex")]
		internal static extern int GetCtrlVarTuple(IntPtr call, int index, out IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetCtrlVarVectorIndex")]
		internal static extern int GetCtrlVarVector(IntPtr call, int index, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetCtrlVarTupleName")]
		internal static extern int GetCtrlVarTuple(IntPtr call, string name, out IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetCtrlVarVectorName")]
		internal static extern int GetCtrlVarVector(IntPtr call, string name, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetIconicVarObjectIndex")]
		internal static extern int GetIconicVarObject(IntPtr call, int index, out IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetIconicVarVectorIndex")]
		internal static extern int GetIconicVarVector(IntPtr call, int index, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetIconicVarObjectName")]
		internal static extern int GetIconicVarObject(IntPtr call, string name, out IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetIconicVarVectorName")]
		internal static extern int GetIconicVarVector(IntPtr call, string name, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateProcedure")]
		internal static extern int CreateProcedure(out IntPtr procedure);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyProcedure")]
		internal static extern int DestroyProcedure(IntPtr procedure);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenLoadProcedure")]
		internal static extern int LoadProcedure(IntPtr procedure, string procedureName);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int HCenLoadProcedureProgramName(IntPtr procedure, IntPtr programName, string procedureName);

		internal static int LoadProcedure(IntPtr procedure, string programName, string procedureName)
		{
			IntPtr intPtr = HalconAPI.ToHGlobalUtf8Encoding(programName);
			int result = EngineAPI.HCenLoadProcedureProgramName(procedure, intPtr, procedureName);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenLoadProcedureProgram")]
		internal static extern int LoadProcedure(IntPtr procedure, IntPtr program, string procedureName);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		private static extern int HCenGetProcedureInfo(IntPtr procedure, out IntPtr name, out IntPtr shortDescription, out bool loaded, IntPtr parNamesIconicInput, IntPtr parNamesIconicOutput, IntPtr parNamesCtrlInput, IntPtr parNamesCtrlOutput, IntPtr parDimsIconicInput, IntPtr parDimsIconicOutput, IntPtr parDimsCtrlInput, IntPtr parDimsCtrlOutput);

		internal static void GetProcedureInfo(IntPtr procedure, out string name, out string shortDescription, out bool loaded, out HTuple parNamesIconicInput, out HTuple parNamesIconicOutput, out HTuple parNamesCtrlInput, out HTuple parNamesCtrlOutput, out HTuple parDimsIconicInput, out HTuple parDimsIconicOutput, out HTuple parDimsCtrlInput, out HTuple parDimsCtrlOutput)
		{
			IntPtr intPtr;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr));
			IntPtr intPtr2;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr2));
			IntPtr intPtr3;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr3));
			IntPtr intPtr4;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr4));
			IntPtr intPtr5;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr5));
			IntPtr intPtr6;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr6));
			IntPtr intPtr7;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr7));
			IntPtr intPtr8;
			EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr8));
			IntPtr intPtr9;
			IntPtr intPtr10;
			EngineAPI.HCkE(EngineAPI.HCenGetProcedureInfo(procedure, out intPtr9, out intPtr10, out loaded, intPtr, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, intPtr7, intPtr8));
			name = HalconAPI.FromHalconEncoding(intPtr9, true);
			shortDescription = HalconAPI.FromHalconEncoding(intPtr10, true);
			parNamesIconicInput = HalconAPI.LoadTuple(intPtr);
			parNamesIconicOutput = HalconAPI.LoadTuple(intPtr2);
			parNamesCtrlInput = HalconAPI.LoadTuple(intPtr3);
			parNamesCtrlOutput = HalconAPI.LoadTuple(intPtr4);
			parDimsIconicInput = HalconAPI.LoadTuple(intPtr5);
			parDimsIconicOutput = HalconAPI.LoadTuple(intPtr6);
			parDimsCtrlInput = HalconAPI.LoadTuple(intPtr7);
			parDimsCtrlOutput = HalconAPI.LoadTuple(intPtr8);
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetUsedProcedureNames")]
		internal static extern int GetUsedProcedureNamesForProcedure(IntPtr procedure, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcCompileUsedProcedures")]
		internal static extern int CompileUsedProceduresForProcedure(IntPtr procedure, out bool ret);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetInfo")]
		internal static extern int GetProcInfo(IntPtr procedure, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetParamInfo")]
		internal static extern int GetParamInfo(IntPtr procedure, string parName, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetInputIconicParamInfo")]
		internal static extern int GetInputIconicParamInfo(IntPtr procedure, int parIdx, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetOutputIconicParamInfo")]
		internal static extern int GetOutputIconicParamInfo(IntPtr procedure, int parIdx, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetInputCtrlParamInfo")]
		internal static extern int GetInputCtrlParamInfo(IntPtr procedure, int parIdx, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcGetOutputCtrlParamInfo")]
		internal static extern int GetOutputCtrlParamInfo(IntPtr procedure, int parIdx, string slot, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcQueryInfo")]
		internal static extern int QueryInfo(IntPtr procedure, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenProcQueryParamInfo")]
		internal static extern int QueryParamInfo(IntPtr procedure, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateProcedureCall")]
		internal static extern int CreateProcedureCall(IntPtr program, out IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyProcedureCall")]
		internal static extern int DestroyProcedureCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenExecuteProcedureCall")]
		internal static extern int ExecuteProcedureCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetWaitForDebugConnectionProcedureCall")]
		internal static extern int SetWaitForDebugConnectionProcedureCall(IntPtr call, bool wait_once);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenResetProcedureCall")]
		internal static extern int ResetProcedureCall(IntPtr call);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputCtrlParamTupleIndex")]
		internal static extern int SetInputCtrlParamTuple(IntPtr call, int index, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputCtrlParamTupleName")]
		internal static extern int SetInputCtrlParamTuple(IntPtr call, string name, IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputCtrlParamVectorIndex")]
		internal static extern int SetInputCtrlParamVector(IntPtr call, int index, IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputCtrlParamVectorName")]
		internal static extern int SetInputCtrlParamVector(IntPtr call, string name, IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputIconicParamObjectIndex")]
		internal static extern int SetInputIconicParamObject(IntPtr call, int index, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputIconicParamObjectName")]
		internal static extern int SetInputIconicParamObject(IntPtr call, string name, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputIconicParamVectorIndex")]
		internal static extern int SetInputIconicParamVector(IntPtr call, int index, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetInputIconicParamVectorName")]
		internal static extern int SetInputIconicParamVector(IntPtr call, string name, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputCtrlParamTupleIndex")]
		internal static extern int GetOutputCtrlParamTuple(IntPtr call, int index, out IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputCtrlParamTupleName")]
		internal static extern int GetOutputCtrlParamTuple(IntPtr call, string name, out IntPtr tuple);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputCtrlParamVectorIndex")]
		internal static extern int GetOutputCtrlParamVector(IntPtr call, int index, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputCtrlParamVectorName")]
		internal static extern int GetOutputCtrlParamVector(IntPtr call, string name, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputIconicParamObjectIndex")]
		internal static extern int GetOutputIconicParamObject(IntPtr call, int index, out IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputIconicParamObjectName")]
		internal static extern int GetOutputIconicParamObject(IntPtr call, string name, out IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputIconicParamVectorIndex")]
		internal static extern int GetOutputIconicParamVector(IntPtr call, int index, out IntPtr vector);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetOutputIconicParamVectorName")]
		internal static extern int GetOutputIconicParamVector(IntPtr call, string name, out IntPtr vector);

		internal static int CreateObjectVector(HObjectVector inVector, out IntPtr vectorHandle)
		{
			int dimension = inVector.Dimension;
			IntPtr intPtr;
			EngineAPI.HCkE(EngineAPI.CreateObjectVector(dimension, out intPtr));
			EngineAPI.HCkE(EngineAPI.StoreObjectVector(inVector, intPtr));
			GC.KeepAlive(inVector);
			vectorHandle = intPtr;
			return 2;
		}

		internal static int StoreObjectVector(HObjectVector inVector, IntPtr vectorHandle)
		{
			int dimension = inVector.Dimension;
			int length = inVector.Length;
			if (dimension == 1)
			{
				for (int i = length - 1; i >= 0; i--)
				{
					EngineAPI.HCkE(EngineAPI.SetObjectVectorObject(vectorHandle, i, inVector[i].O.Key));
				}
			}
			else
			{
				for (int j = length - 1; j >= 0; j--)
				{
					IntPtr intPtr;
					EngineAPI.HCkE(EngineAPI.CreateObjectVector(inVector[j], out intPtr));
					EngineAPI.HCkE(EngineAPI.SetObjectVectorVector(vectorHandle, j, intPtr));
					EngineAPI.HCkE(EngineAPI.DestroyObjectVector(intPtr));
				}
			}
			GC.KeepAlive(inVector);
			return 2;
		}

		internal static HObjectVector GetAndDestroyObjectVector(IntPtr vectorHandle)
		{
			int num;
			EngineAPI.HCkE(EngineAPI.GetObjectVectorDimension(vectorHandle, out num));
			HObjectVector hObjectVector = new HObjectVector(num);
			EngineAPI.HCkE(EngineAPI.LoadObjectVector(hObjectVector, vectorHandle));
			EngineAPI.HCkE(EngineAPI.DestroyObjectVector(vectorHandle));
			return hObjectVector;
		}

		internal static int LoadObjectVector(HObjectVector outVector, IntPtr vectorHandle)
		{
			int num;
			EngineAPI.HCkE(EngineAPI.GetObjectVectorDimension(vectorHandle, out num));
			int num2;
			EngineAPI.HCkE(EngineAPI.GetObjectVectorLength(vectorHandle, out num2));
			if (num == 1)
			{
				for (int i = num2 - 1; i >= 0; i--)
				{
					IntPtr intPtr;
					EngineAPI.HCkE(EngineAPI.GetObjectVectorObject(vectorHandle, i, out intPtr));
					outVector[i].O = new HObject(intPtr, false);
				}
			}
			else
			{
				for (int j = num2 - 1; j >= 0; j--)
				{
					IntPtr intPtr2;
					EngineAPI.HCkE(EngineAPI.GetObjectVectorVector(vectorHandle, j, out intPtr2));
					EngineAPI.HCkE(EngineAPI.LoadObjectVector(outVector[j], intPtr2));
					EngineAPI.HCkE(EngineAPI.DestroyObjectVector(intPtr2));
				}
			}
			return 2;
		}

		internal static int CreateTupleVector(HTupleVector inVector, out IntPtr vectorHandle)
		{
			int dimension = inVector.Dimension;
			IntPtr intPtr;
			EngineAPI.HCkE(EngineAPI.CreateTupleVector(dimension, out intPtr));
			EngineAPI.HCkE(EngineAPI.StoreTupleVector(inVector, intPtr));
			GC.KeepAlive(inVector);
			vectorHandle = intPtr;
			return 2;
		}

		internal static int StoreTupleVector(HTupleVector inVector, IntPtr vectorHandle)
		{
			int dimension = inVector.Dimension;
			int length = inVector.Length;
			if (dimension == 1)
			{
				for (int i = length - 1; i >= 0; i--)
				{
					IntPtr intPtr;
					EngineAPI.HCkE(HalconAPI.CreateTuple(out intPtr));
					HalconAPI.StoreTuple(intPtr, inVector[i].T);
					EngineAPI.HCkE(EngineAPI.SetTupleVectorTuple(vectorHandle, i, intPtr));
				}
			}
			else
			{
				for (int j = length - 1; j >= 0; j--)
				{
					IntPtr intPtr2;
					EngineAPI.HCkE(EngineAPI.CreateTupleVector(inVector[j], out intPtr2));
					EngineAPI.HCkE(EngineAPI.SetTupleVectorVector(vectorHandle, j, intPtr2));
				}
			}
			GC.KeepAlive(inVector);
			return 2;
		}

		internal static HTupleVector GetAndDestroyTupleVector(IntPtr vectorHandle)
		{
			int num;
			EngineAPI.HCkE(EngineAPI.GetTupleVectorDimension(vectorHandle, out num));
			HTupleVector hTupleVector = new HTupleVector(num);
			EngineAPI.HCkE(EngineAPI.LoadTupleVector(hTupleVector, vectorHandle));
			return hTupleVector;
		}

		internal static int LoadTupleVector(HTupleVector outVector, IntPtr vectorHandle)
		{
			int num;
			EngineAPI.HCkE(EngineAPI.GetTupleVectorDimension(vectorHandle, out num));
			int num2;
			EngineAPI.HCkE(EngineAPI.GetTupleVectorLength(vectorHandle, out num2));
			if (num == 1)
			{
				for (int i = num2 - 1; i >= 0; i--)
				{
					IntPtr intPtr;
					EngineAPI.HCkE(EngineAPI.GetTupleVectorTuple(vectorHandle, i, out intPtr));
					outVector[i].T = HalconAPI.LoadTuple(intPtr);
				}
			}
			else
			{
				for (int j = num2 - 1; j >= 0; j--)
				{
					IntPtr intPtr2;
					EngineAPI.HCkE(EngineAPI.GetTupleVectorVector(vectorHandle, j, out intPtr2));
					EngineAPI.HCkE(EngineAPI.LoadTupleVector(outVector[j], intPtr2));
				}
			}
			return 2;
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateTupleVector")]
		internal static extern int CreateTupleVector(int dimension, out IntPtr vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyTupleVector")]
		internal static extern int DestroyTupleVector(IntPtr vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetTupleVectorDimension")]
		internal static extern int GetTupleVectorDimension(IntPtr vector_handle, out int dimension);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetTupleVectorLength")]
		internal static extern int GetTupleVectorLength(IntPtr vector_handle, out int length);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetTupleVectorElementVector")]
		internal static extern int SetTupleVectorVector(IntPtr vector_handle, int index, IntPtr element_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetTupleVectorElementTuple")]
		internal static extern int SetTupleVectorTuple(IntPtr vector_handle, int index, IntPtr element_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetTupleVectorElementVector")]
		internal static extern int GetTupleVectorVector(IntPtr vector_handle, int index, out IntPtr element_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetTupleVectorElementTuple")]
		internal static extern int GetTupleVectorTuple(IntPtr vector_handle, int index, out IntPtr element_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateObjectVector")]
		internal static extern int CreateObjectVector(int dimension, out IntPtr vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyObjectVector")]
		internal static extern int DestroyObjectVector(IntPtr vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetObjectVectorDimension")]
		internal static extern int GetObjectVectorDimension(IntPtr vector_handle, out int dimension);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetObjectVectorLength")]
		internal static extern int GetObjectVectorLength(IntPtr vector_handle, out int length);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetObjectVectorElementVector")]
		internal static extern int SetObjectVectorVector(IntPtr vector_handle, int index, IntPtr sub_vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenSetObjectVectorElementObject")]
		internal static extern int SetObjectVectorObject(IntPtr vector_handle, int index, IntPtr key);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetObjectVectorElementVector")]
		internal static extern int GetObjectVectorVector(IntPtr vector_handle, int index, out IntPtr sub_vector_handle);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenGetObjectVectorElementObject")]
		internal static extern int GetObjectVectorObject(IntPtr vector_handle, int index, out IntPtr key);

		internal static void AssertObjectClass(IntPtr key, string assertClass, string procedureName)
		{
			if (key != HObjectBase.UNDEF)
			{
				HObject hObject = new HObject(key);
				HTuple objClass = hObject.GetObjClass();
				hObject.Dispose();
				if (objClass.Length > 0)
				{
					string s = objClass.S;
					if (!s.StartsWith(assertClass))
					{
						HDevEngineException.ThrowGeneric(string.Concat(new string[]
						{
							"Output object type mismatch (excepted ",
							assertClass,
							", got ",
							s,
							")"
						}), procedureName);
					}
				}
			}
		}

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenCreateImplementation")]
		internal static extern int CreateImplementation(out IntPtr implementation, DevOpenWindowDelegate delegateDevOpenWindow, DevCloseWindowDelegate delegateDevCloseWindow, DevSetWindowDelegate delegateDevSetWindow, DevGetWindowDelegate delegateDevGetWindow, DevSetWindowExtentsDelegate delegateDevSetWindowExtents, DevSetPartDelegate delegateDevSetPart, DevClearWindowDelegate delegateDevClearWindow, DevDisplayDelegate delegateDevDisplay, DevDispTextDelegate delegateDevDispText, DevSetDrawDelegate delegateDevSetDraw, DevSetShapeDelegate delegateDevSetShape, DevSetColoredDelegate delegateDevSetColored, DevSetColorDelegate delegateDevSetColor, DevSetLutDelegate delegateDevSetLut, DevSetPaintDelegate delegateDevSetPaint, DevSetLineWidthDelegate delegateDevSetLineWidth);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HCenDestroyImplementation")]
		internal static extern int DestroyImplementation(IntPtr implementation);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int HCenGetLastException(out int category, out IntPtr message, out IntPtr procedureName, out IntPtr lineText, out int lineNumber, out IntPtr userData);

		[DllImport("hdevenginecpp", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void HCenReleaseLastException();

		internal static int GetLastException(out int category, out string message, out string procedureName, out string lineText, out int lineNumber, out HTuple userData)
		{
			IntPtr intPtr;
			IntPtr intPtr2;
			IntPtr intPtr3;
			IntPtr intPtr4;
			int result = EngineAPI.HCenGetLastException(out category, out intPtr, out intPtr2, out intPtr3, out lineNumber, out intPtr4);
			try
			{
				message = Marshal.PtrToStringAnsi(intPtr);
				procedureName = Marshal.PtrToStringAnsi(intPtr2);
				lineText = Marshal.PtrToStringAnsi(intPtr3);
				userData = HalconAPI.LoadTuple(intPtr4);
			}
			catch
			{
				message = "Error handling exception";
				procedureName = "";
				lineText = "";
				userData = new HTuple();
			}
			EngineAPI.HCenReleaseLastException();
			return result;
		}

		internal static void HCkE(int err)
		{
			if (err == -1 || (err != 2 && err != 2))
			{
                HDevEngineException.ThrowLastException(err);
            }
		}
	}
}
