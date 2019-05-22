using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    Vector3 playerPos; 
    Vector3 startPos; 
    public Transform destination;
    public Transform hazard;
    GameObject [] hazards;
    GameObject [] barriers;
    public TextMesh playerMessage;

    AudioSource aud;
    public AudioClip moveClip;
    


    // Start is called before the first frame update
    void Start() {
        playerPos = transform.position;
        startPos = playerPos;
        hazards = GameObject.FindGameObjectsWithTag("hazard");
        barriers = GameObject.FindGameObjectsWithTag("barrier");
        aud = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {
        Vector3 newPos = playerPos;

        //Character Movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            newPos = playerPos - transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            newPos = playerPos + transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newPos = playerPos - transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            newPos = playerPos + transform.right;
        }

        bool inABlock = false;
        for (int i = 0; i < barriers.Length; i++)
        {
            if (newPos.x == barriers[i].transform.position.x &&
                newPos.z == barriers[i].transform.position.x)
                {
                    inABlock = true;
                }
        }
        if (!inABlock) {
            playerPos = newPos;
        }


        if (playerPos.x == destination.position.x && 
            playerPos.z == destination.position.z){
            playerPos += transform.up;
        }

        if (playerPos.x == hazard.position.x && 
            playerPos.z == hazard.position.z){
            playerPos = startPos;
        }

        transform.position = playerPos;
    }
}
