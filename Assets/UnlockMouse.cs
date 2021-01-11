using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMouse : MonoBehaviour
{
    void Update()
    {
        if(gameObject.activeSelf==true){
        Cursor.lockState = CursorLockMode.None;

        }
    }

     public void hideCanvas(){
       gameObject.SetActive(false);
       Cursor.lockState = CursorLockMode.Locked;
    }
}
