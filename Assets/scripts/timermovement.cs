using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timermovement : MonoBehaviour
{
    Transform transform_;
    
    public float movimiento;
    float timer;
    float addtimer;
    public float setime;
    bool act1 = true;
    bool act2 = true;
    bool act3 = true;
    bool act4 = true;
    bool act5 = true;
    bool act6 = true;

    // Start is called before the first frame update
    void Awake()
    {
        transform_ = GetComponent<Transform>();
            
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime + addtimer;
        if (timer > setime && act1 == true)
        {
            transform_.position = new Vector2(transform_.position.x + movimiento, transform_.position.y);
            
            act1 = false;
        }
        if (timer > setime*2 && act2 == true)
        {
            transform_.position = new Vector2(transform_.position.x , transform_.position.y- movimiento);
            act2 = false;
        }
        if (timer > setime*3 && act3 == true)
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - movimiento, GetComponent<Transform>().position.y);

            act3 = false;
        }
        if (timer > setime*4 && act4 == true)
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - movimiento, GetComponent<Transform>().position.y );
            act4 = false;

        }
        if (timer > setime*5 && act5 == true)
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - movimiento);
            act5 = false;

        }
        if (timer > setime*6 && act6 == true)
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x + movimiento, GetComponent<Transform>().position.y);
            act6 = false;
            act1 = true;
            act2 = true;
            act3 = true;
            act4 = true;
            act5 = true;
            act6 = true;
            timer = 0;
            addtimer = addtimer + Time.deltaTime/4;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject,100*Time.deltaTime);
    }
}
