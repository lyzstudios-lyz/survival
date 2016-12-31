using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // the speed for the player to move
    public float speed = 10f;

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

        float xVelocity = (horInput * speed) * Time.deltaTime;
        float yVelocity = (vertInput * speed) * Time.deltaTime;
        
        this.transform.GetComponent<Rigidbody2D>().velocity = new Vector3(xVelocity, yVelocity, 0);
    }
}
