using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float speed;
    public GameObject bomb;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        throwBomb();
    }
    void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
    void throwBomb()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bomb, transform.position, bomb.transform.rotation);
        }
    }
}
