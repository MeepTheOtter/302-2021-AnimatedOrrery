using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class setTimeDilation : MonoBehaviour
{

    public static float time = .1f;

    public Button play;
    public Button pause;
    public Button fastForward;
    public Button rewind;

    private bool canSetTime = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > .1f) { }
        time = Mathf.Clamp(time, -.4f, .4f);
    }

    public void enableCanSetTime(bool canSetT)
    {
        canSetTime = canSetT;
    }

    public void setTime(float t)
    {
        if (canSetTime) time = t;

        if (!canSetTime) time += t;  
    }

    
}
