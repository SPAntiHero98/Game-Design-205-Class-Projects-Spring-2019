using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CPUCarAI : MonoBehaviour
{

    NavMeshAgent race;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        race = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        race.destination = target.position;
    }
}
