using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if(collision.gameObject.tag=="Apple")
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("score: "+score);
        }
    }
}
