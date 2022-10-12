using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance = 10.0f;

    private UnityEngine.Object explosion;

    void Start()
    {
        explosion = Resources.Load("Explosion");
        speed = float.Parse(GameObject.Find("SpeedInputedText").GetComponent<Text>().text);
        distance = float.Parse(GameObject.Find("DistanceInputedText").GetComponent<Text>().text);
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x >= distance - 8)
        {
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(gameObject);
        }
    }
}
