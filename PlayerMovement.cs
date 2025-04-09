using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed;   
    }
}
