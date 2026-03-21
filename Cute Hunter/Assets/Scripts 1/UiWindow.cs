
using UnityEngine;
using NaughtyAttributes;
using System;
using DG.Tweening;
public class UiWindow : MonoBehaviour

{
    [Header("UI WINDOW")]
    [SerializeField] private string windowId;
    // Start is 
    // called once before the first execution of Update after the MonoBehaviour is created
    [Header("References")]
    [SerializeField] private Canvas canvas; 
    [SerializeField] private CanvasGroup canvasGroup; 
    public RectTransform _rectTransformCanvasGroup => canvasGroup.GetComponent<RectTransform>();
    

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
        //Doscale
         _rectTransformCanvasGroup.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack).OnComplete(() =>
        {
            Debug.Log($"finalizo window {windowId}");
        });
        canvas.gameObject.SetActive(true);

    }
    //esconder
    [Button]

    public virtual void Hide()
    {
        //DOScale
        _rectTransformCanvasGroup.DOScale(Vector3.zero, 1f).SetEase(Ease.OutBack).OnComplete(() =>
        {
            Debug.Log($"finalizo window {windowId}");
        });
     canvas.gameObject.SetActive(false);
   
    }


}

