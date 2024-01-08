using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementPlayer : MonoBehaviour
{
    public float moveX = 0;
    public float moveY = 0;
    public float speed = 0;

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroide"))
        {

            Destroy(gameObject);
            SceneManager.LoadScene(1);

        }
    }
}
