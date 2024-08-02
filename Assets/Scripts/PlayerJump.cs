using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody rB;
    public BoxCollider bC;
    public LayerMask groundLayer;
    public float jumpSpeed;
    public float rotationSpeed;

    private float sideCheck = -1;
    private bool groundCheck;

    void Update()
    {
        groundCheck = Physics.Raycast(bC.bounds.center, Vector3.down, bC.bounds.extents.y + 0.01f, groundLayer);    //Provjera ako Player dira tlo

        //Provjera za skakanje Player-a
        if (groundCheck == true && Input.GetKeyDown(KeyCode.Mouse0) == true && PauseButton.pauseCheck == false && Input.mousePosition.y < Screen.height * 0.9 && (Input.mousePosition.y > Screen.height * 0.25 || Input.mousePosition.x < Screen.width * 0.72))
        {
                rB.velocity = new Vector3(0, 1, 0) * jumpSpeed;
                if (sideCheck == -1)
                {
                    rB.angularVelocity = new Vector3(0, 0, -1) * rotationSpeed;
                    sideCheck = 1;
                }
                else if (sideCheck == 1)
                {
                    rB.angularVelocity = new Vector3(0, 0, 1) * rotationSpeed;
                    sideCheck = -1;
                }
        }
    }
}
