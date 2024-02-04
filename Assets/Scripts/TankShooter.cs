using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : Shooter
{
    public Transform firepointTransform;
    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public override void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float Lifespan)
    {
        // Clone our projectile
        GameObject newShell = Instantiate(shellPrefab, firepointTransform.position, firepointTransform.rotation) as GameObject;

        //get the DamageOnHit Component 
        DamageOnHit damageOnHit = newShell.GetComponent<DamageOnHit>();

        // if it has one
        if (damageOnHit != null)
        {
            damageOnHit.damageDone = damageDone;

            damageOnHit.owner = GetComponent<Pawn>();
        }
        // get the rigidbody component 
        Rigidbody rigidbody = newShell.GetComponent<Rigidbody>();
        //if it has one
        if (rigidbody != null)
        {
            rigidbody.AddForce(firepointTransform.forward * fireForce);
        }
        //Destroy it after after a set time
        Destroy(newShell, Lifespan);
    }
}
