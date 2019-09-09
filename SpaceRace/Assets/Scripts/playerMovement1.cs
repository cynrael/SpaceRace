using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement1 : MonoBehaviour
{
    public float speed;
    private int score1;
    public Text scoreText1;
    
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0;
        SetScoreText1();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical1 = Input.GetAxis("Vertical1");
        transform.Translate(0, moveVertical1 * speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "score")
        {
            transform.position = new Vector2(-3.5f, -3.5f);
            score1 = score1 + 1;
            Debug.Log(score1);
            
        }
        if (collisionInfo.gameObject.tag == "death")
        {
            //two second delay???
            transform.position = new Vector2(-3.5f, -3.5f);

        }
    }

    void SetScoreText1()
    {
        scoreText1.text = "" + scoreText1.ToString();
    }
}
