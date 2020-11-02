using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private ISelectionResponse _selectionResponse;
    private IRayCastCam _rayFromCam;
    private IRayCastBasedTagSelecter _selecter;

    private Transform _currentselection;
   
    private void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
        _rayFromCam = GetComponent<IRayCastCam>();
        _selecter = GetComponent<IRayCastBasedTagSelecter>();
    
    }

    void Update()
    {
        if (_currentselection != null) _selectionResponse.OnDeselect(_currentselection);
        
        _selecter.Check(_rayFromCam.CreateRay());
        _currentselection= _selecter.GetSelection();

        if (_currentselection != null) _selectionResponse.OnSelect(_currentselection);
       
    }

}
