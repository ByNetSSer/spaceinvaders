using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().position = new Vector2(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y + speed* Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {

            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "muro")
        {
            Destroy(this.gameObject);
        }
    }
}
