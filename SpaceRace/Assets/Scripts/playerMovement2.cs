using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement2 : MonoBehaviour
{
    public float speed;
    public int score2;
    public Text scoreText2;
    private static float time2;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        score2 = 0;
        SetScoreText2();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical2 = Input.GetAxis("Vertical2");
        transform.Translate(0, moveVertical2 * speed * Time.deltaTime, 0);
        time2 = timer.time;
        if (time2 <= 0)
        {
            player2.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "score")
        {
            score2 = score2 + 1;
            SetScoreText2();
            transform.position = new Vector2(3.5f, -3.5f);
            Debug.Log(score2);
            
        }
        if (collisionInfo.gameObject.tag == "death")
        {
            StartCoroutine(methodName: "player2death");
            transform.position = new Vector2(3.5f, 10);
            Destroy(collisionInfo.gameObject);
        }
    }
    
    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
    }

    IEnumerator player2death()
    {
        yield return new WaitForSeconds(seconds: 4);
        transform.position = new Vector2(3.5f, -3.5f);
    }

    void SetScoreText2()
    {
        scoreText2.text = "" + score2;
    }
}
