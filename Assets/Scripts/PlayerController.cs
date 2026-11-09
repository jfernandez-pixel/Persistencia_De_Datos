using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float movementSpeed = 10;
    public int direction;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Teleport();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = 1;
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            direction = 0;
        }
    }

    void FixedUpdate()
    {
        _rigidBody.linearVelocity = Vector3.forward * movementSpeed * direction;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CheckPoint"))
        {
            PlayerPrefs.SetFloat("XPosition", transform.position.x);
            PlayerPrefs.SetFloat("YPosition", transform.position.y);
            PlayerPrefs.SetFloat("ZPosition", transform.position.z);
        }
    }
    
    void Teleport()
    {
        Vector3 teleportPosition;
        teleportPosition.x = PlayerPrefs.GetFloat("XPosition");
        teleportPosition.y = PlayerPrefs.GetFloat("YPosition");
        teleportPosition.z = PlayerPrefs.GetFloat("ZPosition");

        transform.position = teleportPosition;
    }
}
