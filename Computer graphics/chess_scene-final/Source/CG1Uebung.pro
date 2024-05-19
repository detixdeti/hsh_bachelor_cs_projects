QT       += core gui opengl widgets
TEMPLATE = app
TARGET = CgViewer
QMAKE_CXXFLAGS += -std=c++11
CONFIG += c++11

SOURCES += main.cpp \
    CgEvents/CgColorChangeEvent.cpp \
    CgEvents/CgLaneRiesenfeldEvent.cpp \
    CgEvents/CgRotationEvent.cpp \
    CgEvents/CgTranslationEvent.cpp \
    CgQtViewer/CGQtGLRenderWidget.cpp \
    CgQtViewer/CgQtGui.cpp \
    CgBase/CgObservable.cpp \
    CgEvents/CgMouseEvent.cpp \
    CgQtViewer/CgQtMainApplication.cpp \
    CgSceneGraph/CgAppearance.cpp \
    CgSceneGraph/CgCoordSystem.cpp \
    CgSceneGraph/CgLoadObjFile.cpp \
    CgSceneGraph/CgPlane.cpp \
    CgSceneGraph/CgPolyline.cpp \
    CgSceneGraph/CgRay.cpp \
    CgSceneGraph/CgRotation.cpp \
    CgSceneGraph/CgSceneControl.cpp \
    CgEvents/CgKeyEvent.cpp \
    CgSceneGraph/CgExampleTriangle.cpp \
    CgQtViewer/CgQtGlBufferObject.cpp \
    CgQtViewer/CgTrackball.cpp \
    CgEvents/CgWindowResizeEvent.cpp \
    CgEvents/CgLoadObjFileEvent.cpp \
    CgSceneGraph/CgSceneGraph.cpp \
    CgSceneGraph/CgSceneGraphEntity.cpp \
    CgSceneGraph/CgUnityCube.cpp \
    CgUtils/Functions.cpp \
    CgUtils/ObjLoader.cpp \
    CgEvents/CgTrackballEvent.cpp

HEADERS += \
    CgEvents/CgColorChangeEvent.h \
    CgEvents/CgLaneRiesenfeldEvent.h \
    CgEvents/CgRotationEvent.h \
    CgEvents/CgTranslationEvent.h \
    CgQtViewer/CgQtGLRenderWidget.h \
    CgQtViewer/CgQtGui.h \
    CgBase/CgObserver.h \
    CgBase/CgObservable.h \
    CgBase/CgBaseEvent.h \
    CgBase/CgEnums.h \
    CgEvents/CgMouseEvent.h \
    CgQtViewer/CgQtMainApplication.h \
    CgSceneGraph/CgAABB.h \
    CgSceneGraph/CgAppearance.h \
    CgSceneGraph/CgCoordSystem.h \
    CgSceneGraph/CgLoadObjFile.h \
    CgSceneGraph/CgPlane.h \
    CgSceneGraph/CgPolyline.h \
    CgSceneGraph/CgRay.h \
    CgSceneGraph/CgRotation.h \
    CgSceneGraph/CgSceneControl.h \
    CgEvents/CgKeyEvent.h \
    CgBase/CgBaseRenderer.h \
    CgBase/CgBaseRenderableObject.h \
    CgSceneGraph/CgExampleTriangle.h \
    CgBase/CgBasePointCloud.h \
    CgBase/CgBaseTriangleMesh.h \
    CgBase/CgBasePolygonMesh.h \
    CgBase/CgBasePolyline.h \
    CgBase/CgBaseSceneControl.h \
    CgQtViewer/CgQtGlBufferObject.h \
    CgQtViewer/CgTrackball.h \
    CgEvents/CgWindowResizeEvent.h \
    CgEvents/CgLoadObjFileEvent.h \
    CgSceneGraph/CgSceneGraph.h \
    CgSceneGraph/CgSceneGraphEntity.h \
    CgSceneGraph/CgUnityCube.h \
    CgUtils/Functions.h \
    CgUtils/ObjLoader.h \
    CgBase/CgBaseImage.h \
    CgEvents/CgTrackballEvent.h

