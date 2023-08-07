using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    //campos del gameobject
    [SerializeField] private GameObject MainMenuCanvas;
    [SerializeField] private GameObject ItemsMenuCanvas;
    [SerializeField] private GameObject ArPositionCanvas;
    void Start()
    { //susssssscribir un evento
        GameManager.instance.OnMainMenu+= ActivateMainMenu;
        GameManager.instance.OnItemsMenu+= ActivateItemsMenu;
        GameManager.instance.OnArPosition+= ActivateARPosition;
    }

    
    private void ActivateMainMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1),0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1),0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1,1,1),0.3f);
        //ocultar los demas botones
        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0),0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0),0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180,0.3f); //psociion final y segundos

        
        ArPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0),0.3f);
        ArPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0),0.3f); 
       
    }
    private void ActivateItemsMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0),0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0),0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0),0.3f);
        
        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1),0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1),0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300,0.3f);

    }
    private void ActivateARPosition(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0),0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0),0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0),0.3f);
        
        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0),0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0),0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180,0.3f);
        
        ArPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1),0.3f);
        ArPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1),0.3f);        

    }
}
