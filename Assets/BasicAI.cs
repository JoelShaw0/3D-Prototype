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
    public GameObject run1;
    public GameObject run2;
    public GameObject run3;
    public GameObject run4;
    public GameObject defaultPosition;
    public GameObject ground;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        int num = Random.Range(0, 4);
            
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider != ground)
        {
            Debug.DrawRay(transform.position, transform.forward, Color.green); 
            print("Hit");
            agent.speed = 40;
            if (num == 1)
            {
                Debug.Log(num);
                agent.SetDestination(run1.transform.position);
            }
            else if (num == 2)
            {
                Debug.Log(num);
                agent.SetDestination(run2.transform.position);
            }
            else if (num == 3)
            {
                Debug.Log(num);
                agent.SetDestination(run3.transform.position);
            }
            else if (num == 4)
            {
                Debug.Log(num);
                agent.SetDestination(run4.transform.position);
            }
            else
            {
                ;
            }
        }
        else
        {
            agent.speed = 40;
            agent.SetDestination(defaultPosition.transform.position);
            Debug.Log(defaultPosition.transform.position);
        }

        if (Input.GetMouseButtonDown(0))
        {
            agent.speed = 1000;
            agent.SetDestination(agent.transform.position + new Vector3(20.0f, 20.0f, 20.0f));
        }
        //}
    }
}
