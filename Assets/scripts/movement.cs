using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rigid_;
    float horizontal;
    float vertical;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rigid_ = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rigid_.velocity = new Vector2(horizontal* speed,vertical*speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
