using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PopUpUi : UiWindow
{
    public Button buttonPlay;
    public Button buttonMusic;
    public Button buttonExit;
    public Button buttonInventory;
    public Button buttonShop;
    public override void Initialize()
    {
        base.Initialize();
        buttonPlay.onClick.AddListener(TouchPlay);
        buttonMusic.onClick.AddListener(TouchMusic);
        buttonExit.onClick.AddListener(TouchExit);
        buttonInventory.onClick.AddListener(TouchInventory);
        buttonShop.onClick.AddListener(TouchShop);
    }
    public void TouchPlay()
    {
        UIPlay play = UiManager.Instance.GetWindow("PlayUI") as UIPlay;
       if(play == null)
        {
            Debug.Log("Ayuda no exisssteeeee");
        }
       play.Show(); 
       Hide();

    }
    public void TouchMusic()
    {
         MusicUi music = UiManager.Instance.GetWindow("MusicUi") as MusicUi;
       if(music == null)
        {
            Debug.Log("Musica no esta.");
        }
        music.Show();
        
    }
    public void TouchExit()
    {
        ExitUi exit = UiManager.Instance.GetWindow("ExitUi") as ExitUi;
        if(exit == null)
        {
            Debug.Log("Configuracion no existe.");
        }
        exit.Show();
    }
    public void TouchInventory()
    {
        IventoryUI iventory = UiManager.Instance.GetWindow("IventoryUI") as IventoryUI;
       if( iventory == null)
        {
            Debug.Log("Inventory fue robado.");
        }
        iventory.Show();
        Hide();
    }
     public void TouchShop()
    {
         ShopUi shop = UiManager.Instance.GetWindow("ShopUi") as ShopUi;
       if(shop == null)
        {
            Debug.Log("Shop no trabajo.");
        }
        shop.Show();
        Hide();
    }
}
