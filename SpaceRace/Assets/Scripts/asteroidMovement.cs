using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{

    public float speed;
    public float y;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "left")
        {
            transform.position = new Vector2(6, y);
        }
        if (collisionInfo.gameObject.tag == "right")
        {
            transform.position = new Vector2(-6, y);
        }
    }
}
