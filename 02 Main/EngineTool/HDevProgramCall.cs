using System;

namespace HalconDotNet
{
	public class HDevProgramCall : IDisposable
	{
		private IntPtr call = IntPtr.Zero;

		private HDevProgram program;

		public HDevProgramCall(HDevProgram program)
		{
			HDevProgramCall.HCkE(EngineAPI.CreateProgramCall(program.Handle, out this.call));
			GC.KeepAlive(this);
			this.program = program;
		}

		public bool IsInitialized()
		{
			return this.call != IntPtr.Zero;
		}

		public HDevProgram GetProgram()
		{
			return this.program;
		}

		public void Execute()
		{
			HDevProgramCall.HCkE(EngineAPI.ExecuteProgramCall(this.call));
			GC.KeepAlive(this);
		}

		public void SetWaitForDebugConnection(bool wait_once)
		{
			HDevProgramCall.HCkE(EngineAPI.SetWaitForDebugConnectionProgramCall(this.call, wait_once));
			GC.KeepAlive(this);
		}

		public void Reset()
		{
			HDevProgramCall.HCkE(EngineAPI.ResetProgramCall(this.call));
			GC.KeepAlive(this);
		}

		public HTuple GetCtrlVarTuple(int index)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetCtrlVarTuple(this.call, index, out intPtr));
			GC.KeepAlive(this);
			return HalconAPI.LoadTuple(intPtr);
		}

		public HTupleVector GetCtrlVarVector(int index)
		{
			IntPtr vectorHandle;
			HDevProgramCall.HCkE(EngineAPI.GetCtrlVarVector(this.call, index, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyTupleVector(vectorHandle);
		}

		public HTuple GetCtrlVarTuple(string name)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetCtrlVarTuple(this.call, name, out intPtr));
			GC.KeepAlive(this);
			return HalconAPI.LoadTuple(intPtr);
		}

		public HTupleVector GetCtrlVarVector(string name)
		{
			IntPtr vectorHandle;
			HDevProgramCall.HCkE(EngineAPI.GetCtrlVarVector(this.call, name, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyTupleVector(vectorHandle);
		}

		public HObject GetIconicVarObject(int index)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, index, out intPtr));
			GC.KeepAlive(this);
			return new HObject(intPtr);
		}

		public HObjectVector GetIconicVarVector(int index)
		{
			IntPtr vectorHandle;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarVector(this.call, index, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyObjectVector(vectorHandle);
		}

		public HObject GetIconicVarObject(string name)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, name, out intPtr));
			GC.KeepAlive(this);
			return new HObject(intPtr);
		}

		public HObjectVector GetIconicVarVector(string name)
		{
			IntPtr vectorHandle;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarVector(this.call, name, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyObjectVector(vectorHandle);
		}

		public HImage GetIconicVarImage(int index)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, index, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "image", "main");
			return new HImage(intPtr);
		}

		public HImage GetIconicVarImage(string name)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "image", "main");
			return new HImage(intPtr);
		}

		public HRegion GetIconicVarRegion(int index)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, index, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "region", "main");
			return new HRegion(intPtr);
		}

		public HRegion GetIconicVarRegion(string name)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "region", "main");
			return new HRegion(intPtr);
		}

		public HXLD GetIconicVarXld(int index)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, index, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "xld", "main");
			return new HXLD(intPtr);
		}

		public HXLD GetIconicVarXld(string name)
		{
			IntPtr intPtr;
			HDevProgramCall.HCkE(EngineAPI.GetIconicVarObject(this.call, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "xld", "main");
			return new HXLD(intPtr);
		}

		internal static void HCkE(int err)
		{
			EngineAPI.HCkE(err);
		}

		~HDevProgramCall()
		{
			try
			{
				this.Dispose();
			}
			catch (Exception)
			{
			}
		}

		void IDisposable.Dispose()
		{
			this.Dispose();
		}

		public virtual void Dispose()
		{
			if (this.call != IntPtr.Zero)
			{
				EngineAPI.DestroyProgramCall(this.call);
				this.call = IntPtr.Zero;
			}
			this.program = null;
			GC.SuppressFinalize(this);
			GC.KeepAlive(this);
		}
	}
}
