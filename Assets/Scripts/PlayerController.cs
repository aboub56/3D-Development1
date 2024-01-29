using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public GameObject bulletprefab;
    public GameObject bulletpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *  horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab, transform.position, bulletprefab.transform.rotation);
        }
        

    }
}
