// Code generated by a template
#pragma once
#include "..\export.h"
#include <pcl/io/pcd_io.h>

using namespace pcl;
using namespace std;

#ifdef __cplusplus
extern "C" {
#endif

EXPORT(PCDWriter*) io_pcdwriter_ctor()
{
	return new PCDWriter();
}

EXPORT(void) io_pcdwriter_delete(PCDWriter** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(int32_t) io_pcdwriter_write_xyz(PCDWriter* ptr, const char* str, PointCloud<PointXYZ>* cloud)
{
	return ptr->writeBinary(string(str), *cloud);
}
EXPORT(int32_t) io_pcdwriter_write_xyzrgba(PCDWriter* ptr, const char* str, PointCloud<PointXYZRGBA>* cloud)
{ 
	return ptr->writeBinary(string(str), *cloud);
}
EXPORT(int32_t) io_pcdwriter_write_xyzi(PCDWriter* ptr, const char* str, PointCloud<PointXYZI>* cloud)
{ 
	return ptr->writeBinary(string(str), *cloud);
}


#ifdef __cplusplus  
}
#endif
