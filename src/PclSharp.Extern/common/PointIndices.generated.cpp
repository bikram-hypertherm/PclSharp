// Code generated by a template
#pragma once
#include "..\export.h"
#include <pcl/PointIndices.h>

using namespace pcl;
using namespace std;

#ifdef __cplusplus
extern "C" {
#endif

EXPORT(PointIndices*) pointindices_ctor()
{
	return new PointIndices();
}

EXPORT(void) pointindices_delete(PointIndices** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(vector<int>*) pointindices_indices(PointIndices* ptr)
{
	return &ptr->indices;
}

#ifdef __cplusplus  
}
#endif