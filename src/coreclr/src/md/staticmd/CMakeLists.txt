add_definitions(-DNO_COR)

set(STATICMD_SOURCES
  apis.cpp
)

convert_to_absolute_path(STATICMD_SOURCES ${STATICMD_SOURCES})

add_definitions(-DFEATURE_METADATA_EMIT_ALL)
add_definitions(-DFEATURE_METADATA_EMIT)
add_definitions(-DFEATURE_METADATA_INTERNAL_APIS)

add_library_clr(mdstaticapi ${STATICMD_SOURCES})