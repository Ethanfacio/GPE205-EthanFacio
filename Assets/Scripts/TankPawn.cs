using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
    public float timer = 1;
    private float timeUntilNextEvent;
    // Start is called before the first frame update
   public override void Start()
    {
        base.Start();
       
    }

    // Update is called once per frame
     public override void Update()
    {
        base.Start();
       
    }
   
     public override void MoveForward()
    {
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }

    public override void Shoot()
    {
        shooter.Shoot(shellPrefab, fireForce, damageDone, shellLifespan);
    }

}
