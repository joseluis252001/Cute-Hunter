
using UnityEngine;
using NaughtyAttributes;
using System;
public class UiWindow : MonoBehaviour

{
    [Header("UI WINDOW")]
    [SerializeField] private string windowId;
    // Start is 
    // called once before the first execution of Update after the MonoBehaviour is created
    [Header("References")]
    [SerializeField] private Canvas canvas; 
    [SerializeField] private CanvasGroup canvasGroup; 

     [Header("Settings")]

    [SerializeField] private bool hideOnStart;
    public String  WindowId => windowId;
    void Start()
    {
        Initialize();
    }
    private void Initialize ()
    {
        canvas.gameObject.SetActive(!hideOnStart);
    }
    
    [Button]
//mostrar
    public virtual void Show()
    {
        canvas.gameObject.SetActive(true);
    }
    //esconder
    [Button]

    public virtual void Hide()
    {
     canvas.gameObject.SetActive(false);
    }
}

