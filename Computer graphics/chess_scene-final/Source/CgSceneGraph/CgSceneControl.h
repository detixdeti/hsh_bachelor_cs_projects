#ifndef CGSCENECONTROL_H
#define CGSCENECONTROL_H

#include "CgBase/CgObserver.h"
#include "CgBase/CgBaseSceneControl.h"
#include <glm/glm.hpp>
#include "CgPolyline.h"
#include "CgLoadObjFile.h"
#include "CgSceneGraph.h"
#include "CgSceneGraphEntity.h"
#include "CgBase/CgEnums.h"
#include "CgEvents/CgMouseEvent.h"
#include "CgEvents/CgKeyEvent.h"
#include "CgEvents/CgWindowResizeEvent.h"
#include "CgEvents/CgLoadObjFileEvent.h"
#include "CgEvents/CgTrackballEvent.h"
#include "CgBase/CgBaseRenderer.h"
#include "CgEvents/CgColorChangeEvent.h"
#include "CgEvents/CgLaneRiesenfeldEvent.h"
#include "CgEvents/CgRotationEvent.h"
#include "CgExampleTriangle.h"
#include "CgUnityCube.h"
#include "CgPolyline.h"
#include "CgRotation.h"
#include "CgLoadObjFile.h"
#include "../CgUtils/Functions.h"
#include <iostream>
#include <glm/gtc/matrix_transform.hpp>
#include "CgUtils/ObjLoader.h"
#include <string>
#include <cmath>
#include <vector>
#include <glm/glm.hpp>
#include "glm/gtx/string_cast.hpp"
#include "CgPlane.h"

class CgSceneGraph;
class CgSceneGraphEntity;
class CgBaseEvent;
class CgBaseRenderer;
class CgPolyline;

class CgSceneControl : public CgObserver, public CgBaseSceneControl
{
public:
    CgSceneControl();
    ~CgSceneControl();
    void handleEvent(CgBaseEvent* e);
    void setRenderer(CgBaseRenderer* r);
    CgBaseRenderer*& getRenderer();
    void renderObjects();
    void setScene(CgSceneGraph* scene);
    void setCurrentTransformation(glm::mat4);

    void iterateChildrenSetColor(CgSceneGraphEntity* entity, glm::vec4 color);
    void iterateChildrenRestoreOldColor(CgSceneGraphEntity* entity);

    void pickingIntersection();
    bool IntersectRayPlane(CgPlane& p, float& t, glm::vec3& q);
    void Barycentric(glm::vec3& a, glm::vec3& b, glm::vec3& c, glm::vec3& q, float& u, float& v, float& w);

    CgSceneGraphEntity* getSelectedEntity();
    bool getShowAABB();
private:
    CgSceneGraph* m_scene;

    bool showAABB;

    CgSceneGraphEntity* selected_entity;
    bool entity_selected;
    bool entity_group_selected;
    bool lastPressQ;
    bool lastPressE;

    bool doTranslate;
    bool doScale;
    bool doRotate;
    bool doX;
    bool doY;
    bool doZ;

    CgBaseRenderer* m_renderer;

    glm::mat4 m_current_transformation;
    glm::mat4 m_trackball_rotation;
    glm::mat4 m_lookAt_matrix;
    glm::mat4 m_proj_matrix;
    glm::mat4 m_scalemat;
};

#endif // CGSCENECONTROL_H
