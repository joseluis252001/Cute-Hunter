using Unity.VisualScripting;
using UnityEngine;
using NaughtyAttributes;

public class ResponsiveElement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private RectTransform rectTransform;

    [Header("Moble Anchors")]
    [SerializeField] private Vector2 mobileAnchorMin = new Vector2(0,0);
    [SerializeField] private Vector2 mobileAnchorMax = new Vector2(0,0);

     [Header("Table Anchors")]
     [SerializeField] private Vector2 tableAnchorMin = new Vector2(0,0);
     [SerializeField] private Vector2 tableAnchorMax = new Vector2(0,0);

     ResponsiveManager _responsiveManager;

     void Start()
    {
        _responsiveManager = ResponsiveManager.instance;
        _responsiveManager.OnScreenSizeChanged.AddListener(UpdateAnchors);
        UpdateAnchors();
    }


    // Update is called once per frame
    void UpdateAnchors()
    {
        if(_responsiveManager == null)
        {
          return;  
        }

        if(_responsiveManager.CurrentDeviceType == DeviceType.Mobile)
        {
            SetMobileAnchors();        
        }

        if(_responsiveManager.CurrentDeviceType == DeviceType.Tablet)
        {
            SetTabletAnchors();        
        }
    }

    private void SetMobileAnchors()
    {
        rectTransform.anchorMin = mobileAnchorMin;
        rectTransform.anchorMax = mobileAnchorMax;
    }
    private void SetTabletAnchors()
    {
        rectTransform.anchorMin = tableAnchorMin;
        rectTransform.anchorMax = tableAnchorMax;
    }

    [Button]
    private void saveMobileAnchors()
    {
        Vector2 minAnchors = rectTransform.anchorMin;
        Vector2 maxAnchors = rectTransform.anchorMax;

        mobileAnchorMin = minAnchors;
        mobileAnchorMax = maxAnchors;
    }
    [Button]
    private void saveTableAnchors()
    {
        Vector2 minAnchors = rectTransform.anchorMin;
        Vector2 maxAnchors = rectTransform.anchorMax;

        tableAnchorMin = minAnchors;
        tableAnchorMax = maxAnchors;
    }
}
