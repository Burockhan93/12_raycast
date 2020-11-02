
using UnityEngine;

internal class HighLightSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public Material highlight;
    public Material de_highlight;
    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.de_highlight;
        }
    }
    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.highlight;
        }
    }
}
