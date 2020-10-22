using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldScript : MonoBehaviour
{
    public GameObject VFX;
    public AudioSource coinSound;


    void Update()
    {
        this.gameObject.transform.Rotate(0, 0, 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Ball>().collectedGold++;
        Instantiate(VFX, transform.position, transform.rotation);
        //coinSound.Play();

        Destroy(gameObject);
    }

}
