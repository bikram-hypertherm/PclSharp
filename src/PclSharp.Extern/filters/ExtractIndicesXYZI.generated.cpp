// Code generated by a template
#pragma once
#include "..\export.h"

#include "pcl\pcl_base.h"
#include "pcl\point_types.h"
#include <pcl/filters/extract_indices.h>

using namespace pcl;
using namespace std;

typedef ExtractIndices<PointXYZI> filter_t;
typedef boost::shared_ptr<PointCloud<PointXYZI>> boost_cloud;

#ifdef __cplusplus
extern "C" {
#endif 

EXPORT(filter_t*) filters_extractIndices_xyzi_ctor(bool extractRemovedIndices)
{
	return new filter_t(extractRemovedIndices);
}

EXPORT(void) filters_extractIndices_xyzi_delete(filter_t** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(void) filters_extractIndices_xyzi_filter(ExtractIndices<PointXYZI>* ptr, PointCloud<PointXYZI>* output)
{
	ptr->filter(*output);
}

EXPORT(void) filters_extractIndices_xyzi_setInputCloud(ExtractIndices<PointXYZI>* ptr, PointCloud<PointXYZI>* cloud)
{
	ptr->setInputCloud(boost_cloud(boost_cloud(), cloud));
}

EXPORT(void) filters_extractIndices_xyzi_setIndices(ExtractIndices<PointXYZI>* ptr, vector<int>* indices)
{
	ptr->setIndices(boost::shared_ptr<vector<int>>(boost::shared_ptr<vector<int>>(), indices));
}

EXPORT(void) filters_extractIndices_xyzi_setKeepOrganized(ExtractIndices<PointXYZI>* ptr, int value)
{ ptr->setKeepOrganized(value); }
EXPORT(int) filters_extractIndices_xyzi_getKeepOrganized(ExtractIndices<PointXYZI>* ptr)
{ return ptr->getKeepOrganized(); }

EXPORT(void) filters_extractIndices_xyzi_setNegative(ExtractIndices<PointXYZI>* ptr, int value)
{ ptr->setNegative(value); }
EXPORT(int) filters_extractIndices_xyzi_getNegative(ExtractIndices<PointXYZI>* ptr)
{ return ptr->getNegative(); }

#ifdef __cplusplus  
}
#endif  