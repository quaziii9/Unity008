using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    [SerializeField]
    private float rotSpeed = 150.0f;

    private Vector3 startPosition;
    private Quaternion startRotation;

    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        float amtMove = moveSpeed * Time.deltaTime;
        float amtRot = rotSpeed * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float angle = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * ver * amtMove);
        transform.Rotate(Vector3.up * angle * amtRot);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet(Clone)")
        {
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }

}
