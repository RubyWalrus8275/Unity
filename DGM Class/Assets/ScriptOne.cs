using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Render> ().material.color = Color
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Render>().material.color = Color
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Render>().material.color = Color
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
