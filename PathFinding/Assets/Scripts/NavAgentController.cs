using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentController : MonoBehaviour {

    public Transform destination;
    public Material basic;
    public Material selected;
    Material material;
    NavMeshAgent agent;
    void Start () {

 

        agent = GetComponent<NavMeshAgent>();
        agent.radius += Random.Range(-0.1f, 0.1f);
        agent.speed += Random.Range(-0.5f, 0.5f);

        agent.destination = new Vector3(Random.Range(-17,17), 0, -32.3f);
        material= GetComponent<Renderer>().material;
        material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
		//material=
	}

    private void OnTriggerEnter(Collider other)
    {

        setColorWhite();
    }

    public void setDestination(Vector3 d)
    {
        agent.destination = d;
    }
    public void setColorBlue()
    {
        material.color = Color.blue;         
    }
    public void setColorWhite()
    {
        material.color = Color.white;
    }

    public void setColorRed()
    {
        material.color = Color.red;
    }

}
