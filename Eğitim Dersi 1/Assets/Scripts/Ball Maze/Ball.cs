using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody Brigi;
    public float speed;
    public Text coinText;
    public int collectedGold = 0;

    public int keyNumber = 0;

    void FixedUpdate()
    {
        coinText.text = collectedGold.ToString();

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 action = new Vector3(horizontal, 0.0f, vertical);
        Brigi.AddForce(action * speed);
    }


}
