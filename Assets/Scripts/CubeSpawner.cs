using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public static bool gameOn = false;

    static public float respawnTime = 10.0f;

    static private void spawnCube()
    {
        GameObject p = Instantiate(Resources.Load("Player")) as GameObject;
    }

    static public IEnumerator spawnTime()
    {
        while (gameOn)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCube();
        }
    }
}
