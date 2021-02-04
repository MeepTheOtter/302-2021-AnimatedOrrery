using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public Transform target;

    public Vector3 angle;
    public int rotationSpeed = 30;

    public float speed = 2;
    public float radius = 10;
    private float age = 0;
    

    // Update is called once per frame
    void Update()
    {
        age += Time.deltaTime * speed * setTimeDilation.time;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * radius;
        offset.z = Mathf.Cos(age) * radius;


        //math
        transform.Rotate(0, rotationSpeed * setTimeDilation.time * 4, 0);

        transform.position = target.position + offset;
    }   
}
