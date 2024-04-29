
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fire : MonoBehaviour
{
    [SerializeField] float TimeFire = 1f;
    public GameObject bulletPrefab;

    public GameObject spawnPos;

    private int poolSize = 5;
    private Queue<GameObject> pools = new Queue<GameObject>();


    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.gameObject.SetActive(false);
            pools.Enqueue(bullet);
        }

        StartCoroutine(ShootCoroutine());
    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeFire);

            GameObject bullet = pools.Dequeue();

            pools.Enqueue(bullet);

            //bullet.SetActive(false);
            bullet.SetActive(true);

            bullet.transform.position = spawnPos.transform.position;
            bullet.transform.rotation = spawnPos.transform.rotation;
        }
    }
}
