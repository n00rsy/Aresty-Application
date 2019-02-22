using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrowdController : MonoBehaviour {

    // Use this for initialization
    public GameObject agent;
    public Transform spawnPoint;
    public Transform destination;
    public int numAgents;

	void Start () {
		for(int i = 0; i < numAgents; i++)
        {
            Instantiate(agent, spawnPoint.position+new Vector3(Random.Range(-17,17),0,0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
