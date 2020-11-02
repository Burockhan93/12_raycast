using UnityEngine;

using System.Collections.Generic;

public class ResponsiveSelector : MonoBehaviour, IRayCastBasedTagSelecter
{
    [SerializeField] private List<Selectable> selectables = new List<Selectable>() ;
    private Transform _selection;
    [SerializeField]private float treshold =0.97f; 
    public void Check(Ray ray)
    {
        _selection = null;

        for (int i = 0; i < selectables.Count; i++)
        {
            var closest=0f;
            var vector1 = ray.direction;
            var vector2 = selectables[i].transform.position- ray.origin;

            var lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized);

            selectables[i].lookPercentage = lookPercentage;

            if (lookPercentage > treshold)
            {
                closest = lookPercentage;
                _selection = selectables[i].transform;
            }
        }
    }

    public Transform GetSelection()
    {
        return _selection;
    }
}
