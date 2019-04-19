using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintajNesto : MonoBehaviour
{
    public void PrintActiveMessage()
    {
        Debug.Log("Active");


    }
    public void PrintDeactivateMessage()
    {
        print("Deactivate");
    }



    public void OnMouseEnter()
    {
       
        Debug.Log("Button selected");

    }

    public void OnMouseExit()
    {
       
        Debug.Log("Button deselected");
    }

}

