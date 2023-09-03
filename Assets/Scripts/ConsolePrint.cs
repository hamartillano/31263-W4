using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private int i = 3; // Initialize i to 3 at the start.

    private void Update()
    {
        // Increment i at the start of every frame.
        i++;

        // Print the GameObject's name followed by the value of i.
        Debug.Log(gameObject.name + ":" + i);
    }
}
