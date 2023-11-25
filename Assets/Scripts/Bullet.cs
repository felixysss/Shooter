using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ScoreScript score;
    public Rigidbody2D monRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
        monRigidBody.velocity = Vector3.up*speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.score++;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
