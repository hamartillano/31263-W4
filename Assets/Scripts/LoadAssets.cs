using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;

    private void Start()
    {
        // Limit the frame rate to 60 FPS.
        Application.targetFrameRate = 60;

        // Instantiate the red prefab at (2, 0, 0) with no rotation.
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Instantiate the blue prefab at (-2, 0, 0) with no rotation.
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
