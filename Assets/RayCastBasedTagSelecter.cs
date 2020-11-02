using UnityEngine;

public class RayCastBasedTagSelecter : MonoBehaviour, IRayCastBasedTagSelecter
{
     Transform _selection;
    public void Check(Ray ray)
    {
        this._selection = null;

        if (Physics.Raycast(ray, out var hit, Mathf.Infinity) && hit.transform.CompareTag("Selectable"))
        {
            var selection = hit.transform;
            this._selection = selection;
        }
    }
    public Transform GetSelection()
    {
        return this._selection;
    }
}

