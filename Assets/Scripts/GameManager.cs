using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnArPosition;

    public static GameManager instance;
    private void Awake()
    {
        if(instance!= null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }
    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activado");
    }
    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activado");
    }
    public void ArPosition()
    {
        OnArPosition?.Invoke();
        Debug.Log("AR Position Activado");
    }
    public void CloseAPP()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
