using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class startScenes : MonoBehaviour
{
    public Button startButton, directionsButton,closeButton,exitButton;
    public TextMeshProUGUI text;
    public Image img;
    
    void Start()
    {
        startButton.onClick.AddListener(startOnclick);
        closeButton.onClick.AddListener(clockOnclick);
        directionsButton.onClick.AddListener(directionsOnclick);
        exitButton.onClick.AddListener(exitOnclick);
    }

    void startOnclick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void clockOnclick()
    {
        img.enabled = false;
        text.enabled = false;
        closeButton.enabled = false;
        closeButton.image.enabled = false;
        startButton.enabled = true;
        directionsButton.enabled = true;
        exitButton.enabled = true;
        exitButton.image.enabled = true;
    }
    void directionsOnclick()
    {
        img.enabled = true;
        text.enabled = true;
        closeButton.enabled = true;
        closeButton.image.enabled = true;
        startButton.enabled = false;
        directionsButton.enabled = false;
        exitButton.enabled = false;
        exitButton.image.enabled = false;
    }
    void exitOnclick()
    {
        Application.Quit();
    }
}
