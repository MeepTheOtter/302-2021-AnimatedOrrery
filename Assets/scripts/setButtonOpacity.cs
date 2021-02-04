using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setButtonOpacity : MonoBehaviour
{

    public Button sun;
    public Button planet1;
    public Button planet2;
    public Button planet3;
    public Button planet4;
    public Button planet5;

    public bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            sun.gameObject.SetActive(true);
            planet1.gameObject.SetActive(true);
            planet2.gameObject.SetActive(true);
            planet3.gameObject.SetActive(true);
            planet4.gameObject.SetActive(true);
            planet5.gameObject.SetActive(true);
        }
        if (!isEnabled)
        {
            sun.gameObject.SetActive(false);
            planet1.gameObject.SetActive(false);
            planet2.gameObject.SetActive(false);
            planet3.gameObject.SetActive(false);
            planet4.gameObject.SetActive(false);
            planet5.gameObject.SetActive(false);
        }
    }

    public void updateButtons()
    {
        if (isEnabled) isEnabled = false;
        else isEnabled = true;
    }
}
