using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    private Ray _lastRay;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        Debug.DrawRay(_lastRay.origin, _lastRay.direction * 100);

        var agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }
}
