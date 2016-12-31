using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // the speed for the player to move
    public float speed = 10f;

    public float runMultiplier = 1.3f;

    // the horizontal direction the player has press
    float horInput;
    // the vertical direction the player has press
    float vertInput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        UpdatePlayerMovementInput();
        MovePlayerByInput();
	}

    void UpdatePlayerMovementInput()
    {
        // the horizontal direction the player has press
        horInput = Input.GetAxis("Horizontal");
        // the vertical direction the player has press
        vertInput = Input.GetAxis("Vertical");
    }

    void MovePlayerByInput()
    {
        Vector3 pos = transform.position;
        float xVelocity;
            float yVelocity;
        if (Input.GetAxis("Run") == 0)
        {
            xVelocity = (horInput * speed) * Time.deltaTime;
            yVelocity = (vertInput * speed) * Time.deltaTime;
        } else
        {
            xVelocity = (horInput * (speed * runMultiplier)) * Time.deltaTime;
            yVelocity = (vertInput * (speed * runMultiplier)) * Time.deltaTime;
        }
        
        
        this.transform.GetComponent<Rigidbody2D>().velocity = new Vector3(xVelocity, yVelocity, 0);
    }
}
