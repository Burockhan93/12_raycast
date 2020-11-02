using UnityEngine;

public  class RayCastfromCam : MonoBehaviour,IRayCastCam
{
    public Camera cam;
    public Ray CreateRay()
    {
        return new Ray(cam.transform.position, cam.transform.forward);
    }
}

