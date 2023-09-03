using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public Renderer rend;
    private int i = 3;

    // Update is called once per frame
    private void Update()
    {
        i++;

        Debug.Log(gameObject.name + ":" + i);
    }
}
