using UnityEngine;

public interface IRayCastBasedTagSelecter
{
    void Check(Ray ray);
    Transform GetSelection();
}

