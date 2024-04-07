using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    // Start is called before the first frame update
    public float posX;
    void Start()
    {
       posX = 1283;
       print("Привет Пупсы");
    }

    // Update is called once per frame
    void Update()
    {
        posX += 0.01f;
        transform.position = new Vector3(posX, 541.17f, 191f);
    }
}
