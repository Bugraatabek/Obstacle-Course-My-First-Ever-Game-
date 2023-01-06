using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }
    void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical")*moveSpeed;
        float xValue = Input.GetAxis("Horizontal")*moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}


