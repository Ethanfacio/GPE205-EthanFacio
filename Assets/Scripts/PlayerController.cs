using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForwardkey;
    public KeyCode moveBackwardkey;
    public KeyCode rotateClockwisekey;
    public KeyCode rotateCounterClockwisekey;

    // for our shooter 
    public KeyCode shootKey;
    // Start is called before the first frame update
    public override void Start()
    {
        if(GameManager.instance != null)
        {
            // register with game manager 
            GameManager.instance.players.Add(this);
        }
        base.Start();
    }


    public override void Update()
    {

        ProcessInputs();


        base.Update();

    }


    public void ProcessInputs()
    {
    
        if (Input.GetKey(moveForwardkey))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackwardkey))
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(rotateClockwisekey))
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterClockwisekey))
        {
            pawn.RotateCounterClockwise();
        }

        if (Input.GetKeyDown(shootKey))
        {
            pawn.Shoot();
        }
    }
    public void OnDestroy()
    {
        //if we have game mananger 
        if (GameManager.instance != null)
        {
            // Insatnce is tracking dead players
            if (GameManager.instance.players != null)
            {
                // deregister with the game mananger
                GameManager.instance.players.Remove(this);
            }
        }
    }
}

