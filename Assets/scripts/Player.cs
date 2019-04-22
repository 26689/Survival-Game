using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour { 
 public int speed;
public int rotationSpeed;
public int jumpSpeed;

    private Vector3 originalPos;

    private float distToGround;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
 {

    if (Input.GetKey(KeyCode.W))
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    if (Input.GetKey(KeyCode.A))
    {
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.S))
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    if (Input.GetKey(KeyCode.D))
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
        GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;
    }
 }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemy")
        {
            gameObject.transform.position = originalPos;
        }
    }
}
