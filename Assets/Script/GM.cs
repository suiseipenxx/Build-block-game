using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GM : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject[] lookblocks;
    public Camera mainCamera;
    public Camera subCamera;
    bool next=true;
    GameObject gO;
    public TextMeshProUGUI scoreText;
    public static int score=0;
    
    bool count = true;
    int rng;
    void Start()
    {

    }

    void Update()
    {
        gameRound();
    }
   
    void gameRound()
    {
        if (next == true)
        {
            rng = Random.Range(0, 6);
            mainCamera.enabled = true;
            subCamera.enabled = false;
            gO = Instantiate(lookblocks[rng], new Vector3(0, 10, 0), Quaternion.identity);
            next = false;
        }
            
        if (count == true && Input.GetKeyUp(KeyCode.Space))
        {
            count = !count;
            changeCamera();
        }
        else if (count == false && Input.GetKeyDown(KeyCode.Space))
        {
            changeCamera();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(gO);
            Instantiate(blocks[rng], new Vector3(RotateBlocks.savepoint.x, RotateBlocks.savepoint.y, RotateBlocks.savepoint.z), Quaternion.identity);
            AddScore();
            next = true;
        }
    }
    public void AddScore()
    {
        score ++;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void changeCamera()
    {
        mainCamera.enabled = !mainCamera.enabled;
        subCamera.enabled = !subCamera.enabled;
    }
}
