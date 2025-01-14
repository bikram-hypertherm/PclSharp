// Code generated by a template
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
namespace PclSharp.Filters
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr filters_voxelGrid_xyzi_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_delete(ref IntPtr ptr);
		//methods
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_filter(IntPtr ptr, IntPtr output);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setIndices(IntPtr ptr, IntPtr indices);

		//properties
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern PointXYZ filters_voxelGrid_xyzi_getLeafSize(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setLeafSize(IntPtr ptr, PointXYZ size);
		
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setFilterFieldName(IntPtr ptr, string name);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_getFilterFieldName(IntPtr ptr, IntPtr str, int dstSz);
		
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_getFilterLimits(IntPtr ptr, ref double min, ref double max);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setFilterLimits(IntPtr ptr, double min, double max);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setDownsampleAllData(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool filters_voxelGrid_xyzi_getDownsampleAllData(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyzi_setMinimumPointsNumberPerVoxel(IntPtr ptr, int value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int filters_voxelGrid_xyzi_getMinimumPointsNumberPerVoxel(IntPtr ptr);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyzi_getMinBoxCoordinates(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyzi_getMaxBoxCoordinates(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyzi_getNrDivisions(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyzi_getDivisionMultiplier(IntPtr ptr);
	}

	public class VoxelGridOfXYZI : VoxelGrid<PointXYZI>
	{
		public PointXYZ LeafSize
		{
			get { return Invoke.filters_voxelGrid_xyzi_getLeafSize(_ptr); }
			set { Invoke.filters_voxelGrid_xyzi_setLeafSize(_ptr, value); }
		}

		public override Eigen.Vector3i MinBoxCoordinates
			=> Invoke.filters_voxelGrid_xyzi_getMinBoxCoordinates(_ptr);

		public override Eigen.Vector3i MaxBoxCoordinates
			=> Invoke.filters_voxelGrid_xyzi_getMaxBoxCoordinates(_ptr);

		public override Eigen.Vector3i NrDivisions
			=> Invoke.filters_voxelGrid_xyzi_getNrDivisions(_ptr);

		public override Eigen.Vector3i DivisionMultiplier
			=> Invoke.filters_voxelGrid_xyzi_getDivisionMultiplier(_ptr);

		public override (double min, double max) FilterLimits
		{
			get
			{
				var min = double.MaxValue; var max = double.MinValue;
				Invoke.filters_voxelGrid_xyzi_getFilterLimits(_ptr, ref min, ref max);
				return (min, max);
			}
			set { Invoke.filters_voxelGrid_xyzi_setFilterLimits(_ptr, value.min, value.max); }
		}

		public unsafe override string FilterFieldName
		{
			get 
			{
				byte* str = stackalloc byte[16];
				Invoke.filters_voxelGrid_xyzi_getFilterFieldName(_ptr, (IntPtr)str, 15);
				str[15] = 0; //just in case the string was too long and they didn't write the null terminator.
				return Marshal.PtrToStringAnsi((IntPtr)str);
			}
			set { Invoke.filters_voxelGrid_xyzi_setFilterFieldName(_ptr, value); }
		}

		public override bool DownsampleAllData
		{
			get { return Invoke.filters_voxelGrid_xyzi_getDownsampleAllData(_ptr); }
            set { Invoke.filters_voxelGrid_xyzi_setDownsampleAllData(_ptr, value); }
		}

		public override int MinimumPointsNumberPerVoxel
		{
			get { return Invoke.filters_voxelGrid_xyzi_getMinimumPointsNumberPerVoxel(_ptr); }
            set { Invoke.filters_voxelGrid_xyzi_setMinimumPointsNumberPerVoxel(_ptr, value); }
		}

		public VoxelGridOfXYZI()
		{
			_ptr = Invoke.filters_voxelGrid_xyzi_ctor();
		}

		public override void SetInputCloud(PointCloud<PointXYZI> cloud)
		{
			Invoke.filters_voxelGrid_xyzi_setInputCloud(_ptr, cloud);
		}

		public override void SetIndices(VectorOfInt indices)
		{
			Invoke.filters_voxelGrid_xyzi_setIndices(_ptr, indices);
		}

		public override void filter(PointCloud<PointXYZI> output)
		{
			Invoke.filters_voxelGrid_xyzi_filter(_ptr, output.Ptr);
		}

		public override ref PointXYZI this[int idx]
		{
			get { return ref this.Index(idx); }
		}

		protected override void DisposeObject()
		{
			Invoke.filters_voxelGrid_xyzi_delete(ref _ptr);
		}
	}
}
