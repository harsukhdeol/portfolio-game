using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
public GameObject Button;
public GameObject Canvas;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver() {
        Button.gameObject.SetActive(true);
    }

    private void OnMouseExit() {
         Button.gameObject.SetActive(false);

    }

    private void OnMouseDown() {
        Canvas.gameObject.SetActive(true);
    }
}
