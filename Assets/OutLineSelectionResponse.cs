
using UnityEngine;

public class OutLineSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnSelect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if(outline != null) outline.OutlineWidth = 20;
    }

    public void OnDeselect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null )outline.OutlineWidth = 0;
    }
}
