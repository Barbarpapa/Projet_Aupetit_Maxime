using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour
{
    public bool hasTarget = false;
    public bool target = false;

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent na = GetComponent<NavMeshAgent>();
        if (hasTarget)
        {
            if (!target)
            {
                na.destination = Camera.main.transform.position;
                target = true;
            }
            if (na.velocity.magnitude < 0.5 || Vector3.Distance(na.destination, Camera.main.transform.position) > 3)
            {
                target = false;
            }
        }
    }
}