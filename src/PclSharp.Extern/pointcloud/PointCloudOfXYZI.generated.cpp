// Code generated by a template
#pragma once
#include "..\export.h"

#include "pcl\pcl_base.h"
#include "pcl\point_types.h"

using namespace pcl;
using namespace std;

typedef vector<PointXYZI, Eigen::aligned_allocator<PointXYZI>> point_vector;

#ifdef __cplusplus  
extern "C" {  // only need to export C interface if  
			  // used by C++ source code  
#endif  

EXPORT(PointCloud<PointXYZI>*) pointcloud_xyzi_ctor()
{
	return new PointCloud<PointXYZI>();
}

EXPORT(PointCloud<PointXYZI>*) pointcloud_xyzi_ctor_wh(uint32_t width, uint32_t height)
{
	return new PointCloud<PointXYZI>(width, height);
}

EXPORT(PointCloud<PointXYZI>*) pointcloud_xyzi_ctor_indices(PointCloud<PointXYZI>* cloud, vector<int>* indices)
{
	if (indices == NULL)
		return new PointCloud<PointXYZI>(*cloud);
	else
		return new PointCloud<PointXYZI>(*cloud, *indices);
}

EXPORT(void) pointcloud_xyzi_delete(PointCloud<PointXYZI>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(PointXYZI*) pointcloud_xyzi_at_colrow(PointCloud<PointXYZI>* ptr, int col, int row)
{
	return &ptr->at(col, row);
}

EXPORT(void) pointcloud_xyzi_add(PointCloud<PointXYZI>* ptr, PointXYZI* value)
{
	//the value needs to be aligned to be pushed into the cloud, so do that.
	PointXYZI deref;
	memcpy(&deref, value, sizeof(PointXYZI));
	ptr->push_back(deref);
}

EXPORT(size_t) pointcloud_xyzi_size(PointCloud<PointXYZI>* ptr)
{
	return ptr->size();
}

EXPORT(void) pointcloud_xyzi_clear(PointCloud<PointXYZI>* ptr)
{
	ptr->clear();
}

EXPORT(uint32_t) pointcloud_xyzi_width(PointCloud<PointXYZI>* ptr)
{
	return ptr->width;
}

EXPORT(void) pointcloud_xyzi_width_set(PointCloud<PointXYZI>* ptr, uint32_t width)
{
	ptr->width = width;
}

EXPORT(uint32_t) pointcloud_xyzi_height(PointCloud<PointXYZI>* ptr)
{
	return ptr->height;
}

EXPORT(void) pointcloud_xyzi_height_set(PointCloud<PointXYZI>* ptr, uint32_t height)
{
	ptr->height = height;
}

EXPORT(int32_t) pointcloud_xyzi_isOrganized(PointCloud<PointXYZI>* ptr)
{
	return ptr->isOrganized();
}

EXPORT(point_vector*) pointcloud_xyzi_points(PointCloud<PointXYZI>* ptr)
{
	return &ptr->points;
}

EXPORT(PointXYZI*) pointcloud_xyzi_data(PointCloud<PointXYZI>* ptr)
{
	return ptr->points.data();
}

EXPORT(void) pointcloud_xyzi_downsample(PointCloud<PointXYZI>* ptr, int factor, PointCloud<PointXYZI>* output)
{
	if (output->width != ptr->width/factor ||
		output->height != ptr->height/factor)
	{
		output->resize(ptr->width/factor * ptr->height/factor);
		output->width = ptr->width/factor;
		output->height = ptr->height/factor;
		output->is_dense = ptr->is_dense;
	}

	if (factor == 1)
	{
		output->points = ptr->points;
		return;
	}

	auto ow = output->width;
	auto oh = output->height;
	auto iw = ptr->width;

	auto oarr = output->points.data();
	auto iarr = ptr->points.data();

	for(size_t c = 0; c < ow; c++)
	{
		for(size_t r = 0; r < oh; r++)
		{
			oarr[r * ow + c] = iarr[r * factor * iw + c * factor];
		}
	}
}

EXPORT(void) pointcloud_xyzi_setIsDense(PointCloud<PointXYZI>* ptr, int value)
{ ptr->is_dense = value; }
EXPORT(int) pointcloud_xyzi_getIsDense(PointCloud<PointXYZI>* ptr)
{ return ptr->is_dense; }

#ifdef __cplusplus  
}
#endif  