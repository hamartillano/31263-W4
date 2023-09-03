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

        if (gameObject.CompareTag("Red") && i == 100)
        {
            // Deactivate the game object if the tag is "Red" and i is 100.
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && i == Random.Range(150, 251))
        {
            // Disable the Renderer component if the tag is "Blue" and i is a random value between 150 and 250.
            rend.enabled = false;
        }

        Debug.Log(gameObject.name + ":" + i);
    }
}
