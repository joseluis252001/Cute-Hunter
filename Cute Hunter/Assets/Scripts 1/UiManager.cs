using UnityEngine;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using NaughtyAttributes;

public class UiManager : MonoBehaviour
{
     [SerializeField] private List <UiWindow> uiWindows = new List<UiWindow>();

    private void Initielize()
    {
        
    }
    [Button]
    private void FindUiInScene()
    {
        //UiWindow.Clear;
    }
    public void ShowPopUpUi()
    {
        SwowWindow("popupui");
    }
    
    public void SwowWindow(string windowId)
    {
        UiWindow windowToShow = null;

        //buscar la ventana, muestrala
        foreach(UiWindow ui in uiWindows)
        {
            if(ui.WindowId == windowId)
            {
                windowToShow = ui;
                break;
            }
        }

        if (windowToShow != null)
        {
            windowToShow.Show();
        }
        else
        {
            Debug.LogError($"No se encontro {windowId}" );
        }
    }
}


