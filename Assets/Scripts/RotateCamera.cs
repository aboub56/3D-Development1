using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject player;
    public float speed = 10;
    private Vector3 offset = new Vector3 (-1.29f, 1.07f, -1.88f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        transform.position = player.transform.position + offset; // Move focal point with player
    }
}
