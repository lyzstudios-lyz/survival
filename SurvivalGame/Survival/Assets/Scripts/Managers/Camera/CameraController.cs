using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.GetComponent<Camera>().fieldOfView = 70;
    }
	
	// Update is called once per frame
	void Update () {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        if (transform.GetComponent<Camera>().fieldOfView > 68 && transform.GetComponent<Camera>().fieldOfView < 100)
        {
            transform.GetComponent<Camera>().fieldOfView += mouseWheel * 50;
        } else if(transform.GetComponent<Camera>().fieldOfView < 68 && mouseWheel > 0)
        {
            transform.GetComponent<Camera>().fieldOfView = 69;
        }
        else if (transform.GetComponent<Camera>().fieldOfView > 100 && mouseWheel < 0)
        {
            transform.GetComponent<Camera>().fieldOfView = 99;
        }
    }
}
