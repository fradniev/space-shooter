using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PLayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed, tilt, attackSpeed;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    private Vector3 target;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = transform.position;
        InvokeRepeating("shoting", 0.1f, attackSpeed);
        SwipeManager.OnSwipeDetected += OnSwipeDetected;
    }
    void OnSwipeDetected(Swipe direction)
    {
        
        Debug.Log(direction);
    }
    private void FixedUpdate()
    {
       /* float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (SwipeManager.IsSwipingLeft())
        {
            Debug.Log(SwipeManager.IsSwipingLeft());
        }
        if (Input.GetButton("Fire1"))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.y = transform.position.y;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x,boundary.xMin, boundary.xMax), 
                0.0f,
                Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x*-tilt);*/
    }


        
        void shoting()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }
}
