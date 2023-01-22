using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;

    public Rigidbody2D rg2d;

    public GameManager managerGame;

    public GameObject DeathScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea"){
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Havada kuşu tutma
            rg2d.velocity = Vector2.up * velocity;
        }
    }
}
