using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 10;
    public float horizontalInput;
    public float speed = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch porjectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



        

    }
}
            


