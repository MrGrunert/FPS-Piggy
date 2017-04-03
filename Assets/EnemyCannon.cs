using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannon : MonoBehaviour
{
    public GameObject monsterCannonballPrefab;
    public Transform target;
    public float range = 12.0f;
    public float playerDmg = 25f;

    private bool onRange = false;

    //public Rigidbody projectile;

    // Use this for initialization
    void Start()
    {
        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
    }

    void Shoot()
    {

        if (onRange)
        {

            var instance = Instantiate(monsterCannonballPrefab, transform.position, transform.rotation);
            var rigidbody = instance.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * 5000);

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);



            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform.tag == "MePlayer")
                {
                    hit.transform.GetComponent<PlayerHealth>().RemoveHealth(playerDmg);
                }
            }
        }

    }


    // Update is called once per frame
    void Update()
    {

        onRange = Vector3.Distance(transform.position, target.position) < range;

        if (onRange)
        {
            transform.LookAt(target);
        }
    }
}

