using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Camera camera;
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

        var bottomLeft = camera.ScreenToWorldPoint(Vector3.zero);
        var topRight = camera.ScreenToWorldPoint(new Vector3(
            camera.pixelWidth, camera.pixelHeight));

        var cameraRect = new Rect(
            bottomLeft.x,
            bottomLeft.y,
            topRight.x - bottomLeft.x,
            topRight.y - bottomLeft.y);

        transform.position = new Vector3(
    Mathf.Clamp(transform.position.x, cameraRect.xMin, cameraRect.xMax),
    Mathf.Clamp(transform.position.y, cameraRect.yMin, cameraRect.yMax),
    transform.position.z);
    }
}
