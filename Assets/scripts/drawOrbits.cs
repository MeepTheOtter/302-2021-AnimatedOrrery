using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawOrbits : MonoBehaviour
{
    public int segments = 100;

    LineRenderer line;

    public GameObject planet;    

    // Start is called before the first frame update
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.SetVertexCount(segments + 1);
        line.SetColors(Color.white, Color.white);
        line.SetWidth(.1f, .1f);
        createPoints(planet.GetComponent<rotate>().radius);
    }    

    void drawLine(LineRenderer l, GameObject p)
    {
        
    }

    void createPoints(float r)
    {
        float x;
        float y = transform.position.y;
        float z;

        float angle = 0;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * r;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * r;
            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }
}
