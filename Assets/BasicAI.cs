using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int numEnemies;
    public Camera cam;
    public NavMeshAgent agent;
    public GameObject run;
    public GameObject stay;
    public GameObject ground;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != ground)
            {
            agent.speed = 5;
            agent.SetDestination(run.transform.position);
            }
            else
            {
            agent.speed = 5;
            agent.SetDestination(stay.transform.position);
            Debug.Log(stay.transform.position);
            }

        if (Input.GetMouseButtonDown(0))
        {
            agent.speed = 30;
            agent.SetDestination(agent.transform.position + new Vector3(0.0f, 0.0f, 5.0f));
        }
        //}
    }
}
