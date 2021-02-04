using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setPosition : MonoBehaviour
{

    public Transform target;

    public float timer = 0;


    // Update is called once per frame
    void Update()
    {
        if (timer <= 0) { }
        //transform.position = target.position;
        if (timer > 0) { }
        transform.position = AnimMath.Slide(transform.position, target.position, .001f);
        if (timer <= 0) timer = 0;
        timer -= Time.deltaTime;
    }

    public void setTarget(Transform t)
    {
        timer = 1;
        target = t;
    }   
}
