using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimaki : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingLeft = true;
    public Transform groundDetection;

    // public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == true)
        {
            if (movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }

        }
    }


    // Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    // transform.position += movement * Time.deltaTime * moveSpeed;


}
