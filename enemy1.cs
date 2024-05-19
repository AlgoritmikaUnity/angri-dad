using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public float speed;
    public int PlayerDamage = 20;
    public Transform target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
    void OnTriggerEnter(Collider Other)
    {
        Player player = Other.GetComponent<Player>();
        //player.TakeDamage(PlayerDamage);
    }
}
