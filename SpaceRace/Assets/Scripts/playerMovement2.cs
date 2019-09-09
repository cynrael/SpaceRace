using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement2 : MonoBehaviour
{
    public float speed;
    private int score2;
    public Text scoreText2;
    
    //1 min 45 second timer 
    
    // Start is called before the first frame update
    void Start()
    {
        score2 = 0;
        SetCountText2();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical2 = Input.GetAxis("Vertical2");
        transform.Translate(0, moveVertical2 * speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "score")
        {
            transform.position = new Vector2(-3.5f, -3.5f);
            score2 = score2 + 1;
            Debug.Log(score2);
            
        }
        if (collisionInfo.gameObject.tag == "death")
        {
            //two second delay???
            transform.position = new Vector2(-3.5f, -3.5f);

        }
    }

    void SetCountText2()
    {
        scoreText2.text = "" + scoreText2.ToString();
    }
}
