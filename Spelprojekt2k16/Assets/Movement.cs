using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody2D>().AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed);
        //GetComponent<Rigidbody2D>().AddForce(Vector2.up * Input.GetAxis("Vertical") * speed);
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }
}
