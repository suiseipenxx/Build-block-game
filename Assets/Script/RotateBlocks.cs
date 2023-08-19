using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class RotateBlocks : MonoBehaviour
{

    public float speedLR = 1.0f; // 左右移动速度
    public float distanceLR = 10.0f; // 左右移动距离
    public float speedFB = 1.0f; // 前后移动速度
    public float distanceFB = 10.0f; // 前后移动距离
    private Vector3 startPositionLR;
    private Vector3 startPositionFB;
    private int directionLR = 5;
    private int directionFB = 5;
    public static Vector3 savepoint=new Vector3(0,10,0);

    private void Start()
    {
        startPositionLR = transform.position;
        startPositionFB = transform.position;
    }                                                                                
    private void Update()
    {
        move();
    }
    private void savePoint()
    {
        savepoint =new Vector3(gameObject.transform.position.x,10, gameObject.transform.position.z);
    }
    private void move()
    {
        savePoint();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            directionLR = 0;
            startPositionFB = transform.position;
        }

        if (directionLR != 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedLR * directionLR);

            if (Mathf.Abs(transform.position.x - startPositionLR.x) >= distanceLR )
            {
                directionLR *= -1;
            }
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speedFB * directionFB);

            if (Mathf.Abs(transform.position.z - startPositionFB.z) >= distanceFB )
            {
                directionFB *= -1;
            }
            if (directionFB != 1 && Input.GetKeyDown(KeyCode.Space))
            {
                speedFB = 0;
                speedLR = 0;
                directionFB = 0;
                directionLR = 0;
                distanceFB = 0;
                distanceLR = 0;
            }
        }
        
    }

    
}
