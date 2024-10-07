using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject aboutPanel;
    public GameObject exitPanel;

    public UnityEvent OnXRPointerEnter;
    public UnityEvent OnXRPointerExit;
    private Camera xRCamera;

    // Use this for initialization
    void Start()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
    }


    public void StartGameClick()
    {
        SceneManager.LoadScene(1);

    }

    public void AboutClicked()
    {
        aboutPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ExitClicked()
    {
        exitPanel.SetActive(true);
        aboutPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
    }

    public void NoClicked()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void YesGameClick()
    {
        Application.Quit();
    }


    public void BackClicked()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);

    }
}