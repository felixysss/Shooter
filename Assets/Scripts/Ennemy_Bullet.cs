using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_Bullet : MonoBehaviour
{
    public GameObject bonus;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(bonus, parent.position, parent.rotation) ;

    }

}
