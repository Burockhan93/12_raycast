using TMPro;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lookPercentagelabel;
    [HideInInspector] public float lookPercentage;

    private void Update()
    {
        lookPercentagelabel.text = lookPercentage.ToString("F3");
    }
}