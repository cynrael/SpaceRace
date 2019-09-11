using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement1 : MonoBehaviour
{
    public float speed;
    public int score1;
    public Text scoreText1;
    private static float time1;
    public GameObject player1;
    
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
        time1 = timer.time;
        if (time1 <= 0)
        {
            player1.SetActive(false);
        }
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "score")
        {
            score1 = score1 + 1;
            SetScoreText1();
            transform.position = new Vector2(-3.5f, -3.5f);
            Debug.Log(score1);
            
        }
        if (collisionInfo.gameObject.tag == "death")
        {
            StartCoroutine(methodName: "player1death");
            transform.position = new Vector2(-3.5f, 10);
            Destroy(collisionInfo.gameObject);
        }
    }

    IEnumerator player1death()
    {
        yield return new WaitForSeconds(seconds: 4);
        transform.position = new Vector2(-3.5f, 3.5f);
    }

    void SetScoreText1()
    {
        scoreText1.text = "" + score1;
    }
    

}
