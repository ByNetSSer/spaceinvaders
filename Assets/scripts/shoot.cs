using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource shoot_S;
    float timeshoot;
    // Update is called once per frame
    void Update()
    {
        timeshoot = timeshoot + Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timeshoot > 250 * Time.deltaTime)
        {
            fire();
            shoot_S.Play();
            timeshoot = 0;
        }
    }
    void fire()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }
}
