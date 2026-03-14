using UnityEngine;
using System.Collections.Generic;

public class UiManager : MonoBehaviour
{
     [SerializeField] private List <UiWindow> uiWindows = new List<UiWindow>();


    public void SwowWindow(string windowId)
    {
        //buscar la ventana, muestrala
        foreach(UiWindow ui in uiWindows)
        {
            if(ui.WindowId == windowId)
            {
                
                return;
            }
        }
    }
}


