using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public GameManagerScript m_MS;

    public GameObject ball;

    private void Update()
    {
        this.gameObject.transform.Rotate(0, 2, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        int collectedTemp = m_MS.collectedCount++;
        m_MS.isCollected[collectedTemp] = true;


        ball.GetComponent<Ball>().collectedGold++;




        Destroy(gameObject);
    }
}
