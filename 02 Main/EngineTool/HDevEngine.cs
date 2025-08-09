using System;

namespace HalconDotNet
{
	public class HDevEngine : IDisposable
	{
		private IntPtr engine = IntPtr.Zero;

		private HDevOperatorWrapper operatorWrapper;

		public HDevEngine()
		{
			HDevEngine.HCkE(EngineAPI.CreateEngine(out this.engine));
			GC.KeepAlive(this);
		}

		public bool IsInitialized()
		{
			return this.engine != IntPtr.Zero;
		}

		public void SetEngineAttribute(string name, HTuple attributeValue)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HalconAPI.StoreTuple(intPtr, attributeValue);
			int err = EngineAPI.SetEngineAttribute(this.engine, name, intPtr);
			GC.KeepAlive(this);
			HDevEngine.HCkE(err);
		}

		public HTuple GetEngineAttribute(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetEngineAttribute(this.engine, name, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public void StartDebugServer()
		{
			HDevEngine.HCkE(EngineAPI.StartDebugServer(this.engine));
			GC.KeepAlive(this);
		}

		public void StopDebugServer()
		{
			HDevEngine.HCkE(EngineAPI.StopDebugServer(this.engine));
			GC.KeepAlive(this);
		}

		public void SetProcedurePath(string path)
		{
			HDevEngine.HCkE(EngineAPI.SetProcedurePath(this.engine, path));
			GC.KeepAlive(this);
		}

		public void AddProcedurePath(string path)
		{
			HDevEngine.HCkE(EngineAPI.AddProcedurePath(this.engine, path));
			GC.KeepAlive(this);
		}

		public HTuple GetProcedureNames()
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetProcedureNames(this.engine, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public HTuple GetLoadedProcedureNames()
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetLoadedProcedureNames(this.engine, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public void UnloadProcedure(string name)
		{
			HDevEngine.HCkE(EngineAPI.UnloadProcedure(this.engine, name));
			GC.KeepAlive(this);
		}

		public void UnloadAllProcedures()
		{
			HDevEngine.HCkE(EngineAPI.UnloadAllProcedures(this.engine));
			GC.KeepAlive(this);
		}

		public HTuple GetGlobalIconicVarNames()
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarNames(this.engine, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public HTuple GetGlobalCtrlVarNames()
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetGlobalCtrlVarNames(this.engine, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public int GetGlobalIconicVarDimension(string name)
		{
			int result;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarDimension(this.engine, name, out result));
			GC.KeepAlive(this);
			return result;
		}

		public int GetGlobalCtrlVarDimension(string name)
		{
			int result;
			HDevEngine.HCkE(EngineAPI.GetGlobalCtrlVarDimension(this.engine, name, out result));
			GC.KeepAlive(this);
			return result;
		}

		public void SetGlobalCtrlVarTuple(string name, HTuple tuple)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HalconAPI.StoreTuple(intPtr, tuple);
			HDevEngine.HCkE(EngineAPI.SetGlobalCtrlVarTuple(this.engine, name, intPtr));
			GC.KeepAlive(this);
		}

		public void SetGlobalCtrlVarVector(string name, HTupleVector vector)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.CreateTupleVector(vector, out intPtr));
			HDevEngine.HCkE(EngineAPI.SetGlobalCtrlVarVector(this.engine, name, intPtr));
			GC.KeepAlive(this);
		}

		public void SetGlobalIconicVarObject(string name, HObject iconic)
		{
			HDevEngine.HCkE(EngineAPI.SetGlobalIconicVarObject(this.engine, name, iconic.Key));
			GC.KeepAlive(iconic);
			GC.KeepAlive(this);
		}

		public void SetGlobalIconicVarVector(string name, HObjectVector vector)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.CreateObjectVector(vector, out intPtr));
			HDevEngine.HCkE(EngineAPI.SetGlobalIconicVarVector(this.engine, name, intPtr));
			GC.KeepAlive(this);
		}

		public HTuple GetGlobalCtrlVarTuple(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(HalconAPI.CreateTuple(out intPtr));
			HDevEngine.HCkE(EngineAPI.GetGlobalCtrlVarTuple(this.engine, name, intPtr));
			GC.KeepAlive(this);
			HTuple result = HalconAPI.LoadTuple(intPtr);
			return result;
		}

		public HTupleVector GetGlobalCtrlVarVector(string name)
		{
			IntPtr vectorHandle;
			HDevEngine.HCkE(EngineAPI.GetGlobalCtrlVarVector(this.engine, name, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyTupleVector(vectorHandle);
		}

		public HObject GetGlobalIconicVarObject(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarObject(this.engine, name, out intPtr));
			GC.KeepAlive(this);
			return new HObject(intPtr, false);
		}

		public HObjectVector GetGlobalIconicVarVector(string name)
		{
			IntPtr vectorHandle;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarVector(this.engine, name, out vectorHandle));
			GC.KeepAlive(this);
			return EngineAPI.GetAndDestroyObjectVector(vectorHandle);
		}

		public HImage GetGlobalIconicVarImage(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarObject(this.engine, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "image", "main");
			return new HImage(intPtr, false);
		}

		public HRegion GetGlobalIconicVarRegion(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarObject(this.engine, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "region", "main");
			return new HRegion(intPtr, false);
		}

		public HXLD GetGlobalIconicVarXld(string name)
		{
			IntPtr intPtr;
			HDevEngine.HCkE(EngineAPI.GetGlobalIconicVarObject(this.engine, name, out intPtr));
			GC.KeepAlive(this);
			EngineAPI.AssertObjectClass(intPtr, "xld", "main");
			return new HXLD(intPtr, false);
		}

		public void SetHDevOperators(IHDevOperators implementation)
		{
			if (implementation == null)
			{
				HDevEngine.HCkE(EngineAPI.SetHDevOperatorImpl(this.engine, IntPtr.Zero));
				GC.KeepAlive(this);
				this.operatorWrapper = null;
				return;
			}
			this.operatorWrapper = new HDevOperatorWrapper(this, implementation);
			HDevEngine.HCkE(EngineAPI.SetHDevOperatorImpl(this.engine, this.operatorWrapper.ImplementationHandle));
			GC.KeepAlive(this);
		}

		internal static void HCkE(int err)
		{
			EngineAPI.HCkE(err);
		}

		~HDevEngine()
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
			if (this.engine != IntPtr.Zero)
			{
				EngineAPI.DestroyEngine(this.engine);
				this.engine = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
			GC.KeepAlive(this);
		}
	}
}
