using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;// ne pas oublier pour manipuler du text


public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textQuiAfficheLeScore;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        textQuiAfficheLeScore.text = " Score "  +score;
    }
}
