using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnemy : MonoBehaviour
{
    public Transform enemy;
    public Transform spPoint;

    public Transform viewer;

    RaycastHit hit;
    Vector3 fwd = Vector3.forward;

    
    void Update()
    {
        viewer.LookAt(enemy);

        transform.rotation = viewer.rotation;

        Vector3 newPoint = new Vector3(spPoint.position.x, viewer.transform.position.y,
            spPoint.position.z);

        Debug.DrawRay(newPoint, spPoint.forward * 4, Color.red);

        if(Physics.Raycast(newPoint, fwd, out hit, 4))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
