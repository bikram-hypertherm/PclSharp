﻿// Code generated by a template
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
namespace PclSharp.IO
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr io_pcdwriter_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void io_pcdwriter_delete(ref IntPtr ptr);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int io_pcdwriter_write_xyz(IntPtr ptr, string fileName, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int io_pcdwriter_write_xyzrgba(IntPtr ptr, string fileName, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int io_pcdwriter_write_xyzi(IntPtr ptr, string fileName, IntPtr cloud);
	}

	public class PCDWriter : UnmanagedObject
	{
		public PCDWriter()
		{
			_ptr = Invoke.io_pcdwriter_ctor();
		}

		public int Write(string fileName, PointCloud<PointXYZ> cloud)
		{
			var res = Invoke.io_pcdwriter_write_xyz(_ptr, fileName, cloud.Ptr);
			return res;
		}

		public int Write(string fileName, PointCloud<PointXYZRGBA> cloud)
		{
			return Invoke.io_pcdwriter_write_xyzrgba(_ptr, fileName, cloud);
		}

		public int Write(string fileName, PointCloud<PointXYZI> cloud)
		{
			return Invoke.io_pcdwriter_write_xyzi(_ptr, fileName, cloud);
		}

		protected override void DisposeObject()
		{
			Invoke.io_pcdwriter_delete(ref _ptr);
		}
	}
}
