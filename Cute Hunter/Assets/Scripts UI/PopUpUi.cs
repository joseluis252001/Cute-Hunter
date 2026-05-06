using UnityEngine;
using UnityEngine.UI;

public class PopUpUi : UiWindow
{
    public Button buttonPlay;
    public override void Initialize()
    {
        base.Initialize();
        buttonPlay.onClick.AddListener(TouchHere);
    }
    public void TouchHere()
    {
        UIPlay play = UiManager.Instance.GetWindow("PlayUI") as UIPlay;
       if(play == null)
        {
            Debug.Log("Ayuda no exisssteeeee");
        }
       play.Show(); 
       Hide();
        
    }
    
}
