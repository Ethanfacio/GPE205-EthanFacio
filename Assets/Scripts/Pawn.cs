
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    //varible for move speed 
    public float moveSpeed;
    // variable for Turn speed
    public float turnSpeed;
    //varible for hoding mover component
    public Mover mover;
    // variable to hold our Shooter
    public Shooter shooter;
    //Get all varaible public for shooter
    // get variable for the shellPrefab
    public GameObject shellPrefab;
    // Variable for the firing force 
    public float fireForce;
    // variable for our damage done
    public float damageDone;
    // varaiable for how long the bullets surive if they don't collide
    public float shellLifespan;
    // Variable for the rate of fire
    public float fireRate;
    // Start is called before the fisrt frame update
    public virtual void Start()
    {
        // get component for mover
        mover = GetComponent<Mover>();
        // get component for shooter
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }
    //this will be override by other objects in our game
    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
}
