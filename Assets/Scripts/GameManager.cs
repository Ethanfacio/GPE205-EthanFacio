using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;
    public Transform playerSpawnTransform;

    public List<PlayerController> players;
    
// awake is called when object is created 
private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //if GameManager instance already exist destroy the game object
            Destroy(gameObject);
        }
    }
private void Start()
    {
        SpawnPlayer();
    }



    public void SpawnPlayer()
    {
        // Spawn the Player Controller 
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity) as GameObject;

        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, Quaternion.identity) as GameObject;

        // Get the Player Controller component and Pawn component. 
        Controller newPlayerController = newPlayerObj.GetComponent<Controller>();

        Pawn newPlayerPawn = newPawnObj.GetComponent<Pawn>();

        
        newPlayerController.pawn = newPlayerPawn;
    }
}
