using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 100;
    public GameObject fireball;
    public Transform attackPoint;
    public int Coins;
    public void collectCoin()
    {
        Coins += 1;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireball, attackPoint.position, attackPoint.rotation);
        }
    }
}
