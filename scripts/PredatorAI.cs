using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorAI : MonoBehaviour {

    Rigidbody predRB; 
    public Transform prey;
    public float forceAmt;

    // Start is called before the first frame update
    void Start(){
        predRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 preyDirection = Vector3.Normalize(prey.position - transform.position);
        predRB.AddForce(preyDirection * forceAmt);
    }
}
