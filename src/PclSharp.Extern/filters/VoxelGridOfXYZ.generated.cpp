// Code generated by a template
#pragma once
#include "..\export.h"

#include "pcl\pcl_base.h"
#include "pcl\point_types.h"
#include <pcl/filters/voxel_grid.h>

using namespace pcl;
using namespace std;

typedef VoxelGrid<PointXYZ> voxel_grid;
typedef boost::shared_ptr<PointCloud<PointXYZ>> boost_cloud;

#ifdef __cplusplus
extern "C" {
#endif 

EXPORT(voxel_grid*) filters_voxelGrid_xyz_ctor()
{
	return new voxel_grid();
}

EXPORT(void) filters_voxelGrid_xyz_delete(voxel_grid** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(void) filters_voxelGrid_xyz_filter(VoxelGrid<PointXYZ>* ptr, PointCloud<PointXYZ>* output)
{
	ptr->filter(*output);
}

EXPORT(void) filters_voxelGrid_xyz_setInputCloud(VoxelGrid<PointXYZ>* ptr, PointCloud<PointXYZ>* cloud)
{
	ptr->setInputCloud(boost_cloud(boost_cloud(), cloud));
}

EXPORT(void) filters_voxelGrid_xyz_setIndices(VoxelGrid<PointXYZ>* ptr, vector<int>* indices)
{
	ptr->setIndices(boost::shared_ptr<vector<int>>(boost::shared_ptr<vector<int>>(), indices));
}

EXPORT(PointXYZ) filters_voxelGrid_xyz_getLeafSize(VoxelGrid<PointXYZ>* ptr)
{
	auto size = ptr->getLeafSize();
	return PointXYZ(size[0], size[1], size[2]);
}

EXPORT(void) filters_voxelGrid_xyz_setLeafSize(VoxelGrid<PointXYZ>* ptr, PointXYZ size)
{
	ptr->setLeafSize(Eigen::Vector4f(size.x, size.y, size.z, 1));
}

EXPORT(void) filters_voxelGrid_xyz_setFilterFieldName(VoxelGrid<PointXYZ>* ptr, const char* str)
{ ptr->setFilterFieldName(string(str)); }

EXPORT(void) filters_voxelGrid_xyz_getFilterFieldName(VoxelGrid<PointXYZ>* ptr, char* str, int dstSz)
{ strcpy_s(str, dstSz, ptr->getFilterFieldName().c_str()); }

EXPORT(void) filters_voxelGrid_xyz_getFilterLimits(VoxelGrid<PointXYZ>* ptr, double* min, double* max)
{ ptr->getFilterLimits(*min, *max); }

EXPORT(void) filters_voxelGrid_xyz_setFilterLimits(VoxelGrid<PointXYZ>* ptr, double min, double max)
{ ptr->setFilterLimits(min, max); }

EXPORT(void) filters_voxelGrid_xyz_setDownsampleAllData(VoxelGrid<PointXYZ>* ptr, int value)
{ ptr->setDownsampleAllData(value); }
EXPORT(int) filters_voxelGrid_xyz_getDownsampleAllData(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getDownsampleAllData(); }

EXPORT(void) filters_voxelGrid_xyz_setMinimumPointsNumberPerVoxel(VoxelGrid<PointXYZ>* ptr, int value)
{ ptr->setMinimumPointsNumberPerVoxel(value); }
EXPORT(int) filters_voxelGrid_xyz_getMinimumPointsNumberPerVoxel(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getMinimumPointsNumberPerVoxel(); }

EXPORT(Eigen::Vector3i) filters_voxelGrid_xyz_getMinBoxCoordinates(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getMinBoxCoordinates(); }

EXPORT(Eigen::Vector3i) filters_voxelGrid_xyz_getMaxBoxCoordinates(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getMaxBoxCoordinates(); }

EXPORT(Eigen::Vector3i) filters_voxelGrid_xyz_getNrDivisions(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getNrDivisions(); }

EXPORT(Eigen::Vector3i) filters_voxelGrid_xyz_getDivisionMultiplier(VoxelGrid<PointXYZ>* ptr)
{ return ptr->getDivisionMultiplier(); }

#ifdef __cplusplus  
}
#endif  