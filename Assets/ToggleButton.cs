using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleButton : MonoBehaviour
{
public GameObject Button;
public GameObject Canvas;


    private void OnMouseOver() {
        Button.gameObject.SetActive(true);
    }

    private void OnMouseExit() {
         Button.gameObject.SetActive(false);

    }

    private void OnMouseDown() {
        if(EventSystem.current.IsPointerOverGameObject())
            return;
        
        Canvas.gameObject.SetActive(true);
    }
}
