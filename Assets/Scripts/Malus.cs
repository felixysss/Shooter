using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malus : MonoBehaviour
{
    public ScoreScript score;
    public Rigidbody2D monRigidBody;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
        monRigidBody.velocity = Vector3.down * speed;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.score -= 3;
        Destroy(gameObject);
        
    }
}
