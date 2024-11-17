using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    float timer;
    float addtimer;
    public float setime;
    bool act1 = true;
    bool act2 = true;
    bool act3 = true;
    bool act4 = true;
    bool act5 = true;
    bool act6 = true;
    public AudioSource one;
    public AudioSource two;
    public AudioSource three;
    public AudioSource four;
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime + addtimer;
        if (timer > setime && act1 == true)
        {

            one.Play();
            act1 = false;
        }
        if (timer > setime * 2 && act2 == true)
        {
            two.Play();
            act2 = false;
        }
        if (timer > setime * 3 && act3 == true)
        {

            three.Play();
            act3 = false;
        }
        if (timer > setime * 4 && act4 == true)
        {
            three.Play();
            act4 = false;

        }
        if (timer > setime * 5 && act5 == true)
        {
            four.Play();
            act5 = false;

        }
        if (timer > setime * 6 && act6 == true)
        {
            one.Play();
            act6 = false;
            act1 = true;
            act2 = true;
            act3 = true;
            act4 = true;
            act5 = true;
            act6 = true;
            timer = 0;
            addtimer = addtimer + Time.deltaTime / 4;
        }

    }
}
