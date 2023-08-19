using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Out : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public TextMeshProUGUI text;
    public Button reload,back;
    public Image img;
    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        animator.SetTrigger("GameOver");
        gameOver();
        back.onClick.AddListener(backStartOnclick);
        reload.onClick.AddListener(reloadOnclick);
    }
    
    void gameOver()
    {
        text.text = "Game Over!\nYour Score: " + GM.score;
        reload.enabled = true;
        reload.image.enabled = true;
        back.enabled = true;
        back.image.enabled = true;
        img.enabled = true;
    }
    void reloadOnclick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void backStartOnclick()
    {
        SceneManager.LoadScene("StartScenes");
    }

}
