using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MusicUi : UiWindow
{
    public Button buttonBack;

 public override void Initialize()
    {
         base.Initialize();
          buttonBack.onClick.AddListener(TouchBack);
    }
     public void TouchBack()
    {
        MusicUi music = UiManager.Instance.GetWindow("MusicUi") as MusicUi;
        if(music == null)
        {
            Debug.Log("Musica no esta.");
        }
        music.Hide();
    }
}