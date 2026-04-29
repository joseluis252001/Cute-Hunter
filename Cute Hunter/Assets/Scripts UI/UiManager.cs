using UnityEngine;
using System;
using System.Collections.Generic;
using NaughtyAttributes;

public class UiManager : MonoBehaviour
{
     [SerializeField] private List <UiWindow> windows = new List<UiWindow>();
       public static UiManager Instance { get; private set; }

        private void Awake()
        {
            //Si ya existe una instancia de UIManager y no es esta, destruir este objeto para mantener el singleton
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
        }
    private void Initielize()
    {
        
    }
    public void ShowPopUpUi()
    {
        SwowWindow("popupui");
    }
    
    public void SwowWindow(string windowId)
    {
        UiWindow windowToShow = null;

        //buscar la ventana, muestrala
        foreach(UiWindow ui in windows)
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
     public void HideWindow(string windowId)
        {
            UiWindow windowToShow = null;

            //Buscar la ventana en la lista de ventanas por su ID
            foreach (UiWindow window in windows)
            {
                //Si se encuentra la ventana con el ID especificado, mostrarla
                if (window.WindowId == windowId)
                {
                    windowToShow = window;
                    break;
                }
            }

            if (windowToShow != null)
            {
                windowToShow.Hide();
            }
            else
            {
                Debug.LogError($"No se encontró la ventana con ID: {windowId}");
            }
        }
        public UiWindow GetWindow(string windowId)
        {
            foreach (var ui in windows)
            {
                if (ui.WindowId == windowId)
                {
                    return ui;
                }
                
            }

            Debug.LogError("No Windo found with id = " + windowId);
            return null;
        }


        #region EDITOR
        [Button]
        private void FindUIInScene()
        {
            //Limpiar la lista de ventanas antes de buscar
            windows.Clear();
            
            //Buscar todas las ventanas de UI en la escena y agregarlas a la lista
            var uiWindows = gameObject.GetComponentsInChildren<UiWindow>(true);
            foreach (var uiWindow in uiWindows)
            {
                if (!windows.Contains(uiWindow))
                {
                    windows.Add(uiWindow);
                }
            }
        }
        #endregion
}


