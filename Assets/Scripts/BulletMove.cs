using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Enemy")
        {
            GameManager.Instance.AddScore(1);
            gameObject.SetActive(false);
        }
    }
}
      
