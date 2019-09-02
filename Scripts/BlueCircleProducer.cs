using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlueCircleProducer : MonoBehaviour
{
    public GameObject blueCircle;
    public GameObject greenCircle;
    public GameObject redCircle;
    public GameObject testDrawingCircle;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(blueCircle, new Vector3(1f, 1f,10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(blueCircle, new Vector3(0f, -1f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(greenCircle, new Vector3(-1f, 0f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(greenCircle, new Vector3(-1f, -1f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(redCircle, new Vector3(-1f, 1f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(redCircle, new Vector3(1f, -1f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(testDrawingCircle, new Vector3(1f, 0f, 10f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(testDrawingCircle, new Vector3(0, 1, 10f), new Quaternion(0f, 0f, 0f, 0f));
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
