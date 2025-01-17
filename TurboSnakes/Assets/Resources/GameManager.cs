﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject snake1;
    public GameObject snake2;
    public GameObject tail1;
    public GameObject tail2;
    Vector3 respawnPosSnake1;
    Quaternion respawnRotSnake1;
    Vector3 respawnPosSnake2;
    Quaternion respawnRotSnake2;
    public bool hasEnded = false;
    public GameObject text;

    private void Start()
    {
        respawnPosSnake1 = new Vector3(0, 2, 0);
        respawnRotSnake1 = new Quaternion(0, 0, 180, 0);
        respawnPosSnake2 = new Vector3(4, -2, 0);
        respawnRotSnake2 = new Quaternion(0, 0, 0, 0);

    }

    void Update()
    {

    }

    public void EndGame()
    {

        //StartCoroutine(PlayEndGameAnimation());
    }

    /*
    IEnumerator PlayEndGameAnimation() 
    {
        yield return new WaitForSeconds(1f);

        snake1.GetComponent<Transform>().position = respawnPosSnake1;
        snake1.GetComponent<Transform>().rotation = respawnRotSnake1;
        snake2.GetComponent<Transform>().position = respawnPosSnake2;
        snake2.GetComponent<Transform>().rotation = respawnRotSnake2;
    }*/

    public void RespawnSnakes()
    {
        snake1.GetComponent<Transform>().position = respawnPosSnake1;
        snake1.GetComponent<Transform>().rotation = respawnRotSnake1;
        snake2.GetComponent<Transform>().position = respawnPosSnake2;
        snake2.GetComponent<Transform>().rotation = respawnRotSnake2;
        //Destroy(tail1.GetComponent<LineRenderer>());
        //Destroy(tail2.GetComponent<LineRenderer>());

    }
}
