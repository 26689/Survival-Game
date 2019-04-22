using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;


    private Vector3 startPos;
    private Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.x > transform.position.x)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (player.transform.position.x < transform.position.x)
        {
            transform.position += -Vector3.right * speed * Time.deltaTime;
        }
        if (player.transform.position.z > transform.position.z)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (player.transform.position.z < transform.position.z)
        {
            transform.position += -Vector3.forward * speed * Time.deltaTime;
        }


    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            gameObject.transform.position = originalPos;
        }
    }
}