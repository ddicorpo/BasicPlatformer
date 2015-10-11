using UnityEngine;
using System.Collections;

public class Moe : MonoBehaviour
{
    public GUIText GameOverText;

    private bool gameOver;
  
    private Rigidbody2D rig;
    private int okayJump = 0;
    public int numberOfJumps = 1;
    // Use this for initialization
    void Start()
    {
       rig = GetComponent<Rigidbody2D>();
        GameOverText.gameObject.SetActive(false);
    }

   public float speed;
    void Update()
    {
        //var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if (!gameOver)
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && okayJump < numberOfJumps)
            {
                rig.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
                okayJump++;
            }
            if (transform.position.y < -10)
            {
                gameOver = true;
            }
            GameObject.Find("Text").GetComponent<GUIText>().text = "" + (int)this.transform.position.x;
        }
        else
        {
            GameOverText.gameObject.SetActive(true);
            //Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
            }
        }
        if(transform.position.y<-15)
        {
            GameOver();
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Platform")
            okayJump = 0;
        if (coll.gameObject.tag == "DeathBlock")
            gameOver = true;

    }

    public void GameOver()
    {
        gameOver = true;
    }
}