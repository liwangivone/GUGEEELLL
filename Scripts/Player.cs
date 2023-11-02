using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.name == "enemy1(Clone)" || hit.transform.name == "enemy2(Clone)")
            {
                Destroy(hit.transform.gameObject);
                score++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}