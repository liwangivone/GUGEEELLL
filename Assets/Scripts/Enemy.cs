using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.Find("AR Camera").GetComponent<Transform>().position);
        transform.Translate(0f, 0f, speed * Time.deltaTime);
    }
}
