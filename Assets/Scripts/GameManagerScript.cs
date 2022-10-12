using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject UI;

    public void StartStopGame()
    {
        CubeSpawner.gameOn = !CubeSpawner.gameOn;
        CubeSpawner.respawnTime = float.Parse(GameObject.Find("TimeInputedText").GetComponent<Text>().text);
        if(GameObject.Find("PlayStopTxt").GetComponent<Text>().text != "Stop")
            GameObject.Find("PlayStopTxt").GetComponent<Text>().text = "Stop";
        else
            GameObject.Find("PlayStopTxt").GetComponent<Text>().text = "Play";
        StartCoroutine(CubeSpawner.spawnTime());
    }
}
