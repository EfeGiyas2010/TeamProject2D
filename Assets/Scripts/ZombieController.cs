using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float speed;
    private Transform target;
    public GameObject erkekPlayer;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Erkek").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Erkek" || col.gameObject.name == "Kýz")
        {
            erkekPlayer.GetComponent<Health>().TakeDamage(1);

        }
    }

}
