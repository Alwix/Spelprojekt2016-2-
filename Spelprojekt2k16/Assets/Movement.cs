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
        Vector2 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        //GetComponent<Rigidbody2D>().AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed);
        //GetComponent<Rigidbody2D>().AddForce(Vector2.up * Input.GetAxis("Vertical") * speed);
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }
}
