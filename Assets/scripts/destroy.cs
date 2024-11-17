using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    Animator animator_;
    // Start is called before the first frame update
    void Awake()
    {
        animator_ = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {

            animator_.SetBool("dead", true);
        }
    }
        void autodestruccion()
            
    {
        Destroy(this.gameObject);
    }
}
