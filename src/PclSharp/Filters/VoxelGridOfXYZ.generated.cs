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
		public static extern IntPtr filters_voxelGrid_xyz_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_delete(ref IntPtr ptr);
		//methods
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_filter(IntPtr ptr, IntPtr output);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setIndices(IntPtr ptr, IntPtr indices);

		//properties
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern PointXYZ filters_voxelGrid_xyz_getLeafSize(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setLeafSize(IntPtr ptr, PointXYZ size);
		
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setFilterFieldName(IntPtr ptr, string name);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_getFilterFieldName(IntPtr ptr, IntPtr str, int dstSz);
		
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_getFilterLimits(IntPtr ptr, ref double min, ref double max);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setFilterLimits(IntPtr ptr, double min, double max);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setDownsampleAllData(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool filters_voxelGrid_xyz_getDownsampleAllData(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_voxelGrid_xyz_setMinimumPointsNumberPerVoxel(IntPtr ptr, int value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int filters_voxelGrid_xyz_getMinimumPointsNumberPerVoxel(IntPtr ptr);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyz_getMinBoxCoordinates(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyz_getMaxBoxCoordinates(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyz_getNrDivisions(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern Eigen.Vector3i filters_voxelGrid_xyz_getDivisionMultiplier(IntPtr ptr);
	}

	public class VoxelGridOfXYZ : VoxelGrid<PointXYZ>
	{
		public PointXYZ LeafSize
		{
			get { return Invoke.filters_voxelGrid_xyz_getLeafSize(_ptr); }
			set { Invoke.filters_voxelGrid_xyz_setLeafSize(_ptr, value); }
		}

		public override Eigen.Vector3i MinBoxCoordinates
			=> Invoke.filters_voxelGrid_xyz_getMinBoxCoordinates(_ptr);

		public override Eigen.Vector3i MaxBoxCoordinates
			=> Invoke.filters_voxelGrid_xyz_getMaxBoxCoordinates(_ptr);

		public override Eigen.Vector3i NrDivisions
			=> Invoke.filters_voxelGrid_xyz_getNrDivisions(_ptr);

		public override Eigen.Vector3i DivisionMultiplier
			=> Invoke.filters_voxelGrid_xyz_getDivisionMultiplier(_ptr);

		public override (double min, double max) FilterLimits
		{
			get
			{
				var min = double.MaxValue; var max = double.MinValue;
				Invoke.filters_voxelGrid_xyz_getFilterLimits(_ptr, ref min, ref max);
				return (min, max);
			}
			set { Invoke.filters_voxelGrid_xyz_setFilterLimits(_ptr, value.min, value.max); }
		}

		public unsafe override string FilterFieldName
		{
			get 
			{
				byte* str = stackalloc byte[16];
				Invoke.filters_voxelGrid_xyz_getFilterFieldName(_ptr, (IntPtr)str, 15);
				str[15] = 0; //just in case the string was too long and they didn't write the null terminator.
				return Marshal.PtrToStringAnsi((IntPtr)str);
			}
			set { Invoke.filters_voxelGrid_xyz_setFilterFieldName(_ptr, value); }
		}

		public override bool DownsampleAllData
		{
			get { return Invoke.filters_voxelGrid_xyz_getDownsampleAllData(_ptr); }
            set { Invoke.filters_voxelGrid_xyz_setDownsampleAllData(_ptr, value); }
		}

		public override int MinimumPointsNumberPerVoxel
		{
			get { return Invoke.filters_voxelGrid_xyz_getMinimumPointsNumberPerVoxel(_ptr); }
            set { Invoke.filters_voxelGrid_xyz_setMinimumPointsNumberPerVoxel(_ptr, value); }
		}

		public VoxelGridOfXYZ()
		{
			_ptr = Invoke.filters_voxelGrid_xyz_ctor();
		}

		public override void SetInputCloud(PointCloud<PointXYZ> cloud)
		{
			Invoke.filters_voxelGrid_xyz_setInputCloud(_ptr, cloud);
		}

		public override void SetIndices(VectorOfInt indices)
		{
			Invoke.filters_voxelGrid_xyz_setIndices(_ptr, indices);
		}

		public override void filter(PointCloud<PointXYZ> output)
		{
			Invoke.filters_voxelGrid_xyz_filter(_ptr, output.Ptr);
		}

		public override ref PointXYZ this[int idx]
		{
			get { return ref this.Index(idx); }
		}

		protected override void DisposeObject()
		{
			Invoke.filters_voxelGrid_xyz_delete(ref _ptr);
		}
	}
}