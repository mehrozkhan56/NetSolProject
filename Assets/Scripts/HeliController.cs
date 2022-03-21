using UnityEngine;

public class HeliController : MonoBehaviour
{
    public float movementSpeed = 10;
    Vector2 movementValue = Vector2.zero;
    public Transform heliObject = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        movementValue.x = Input.GetAxis("Horizontal");
        movementValue.y = Input.GetAxis("Vertical");
        MovementHandling();
        TiltHandling();
    }
    
    public float rotateSpeed = 3f;
    float turn = 0.0f;
    private void MovementHandling()
    {
        transform.position += Vector3.forward * Time.deltaTime * movementSpeed * movementValue.y;
    }

    float currentZRotation = 0.0f;
    public float rotationSpeed = 1000.0f;
    public float minRotation = -30.0f;
    public float maxRotation = 30.0f;
    private void TiltHandling()
    {
        if (movementValue.x == 0)
            currentZRotation = Mathf.MoveTowards(currentZRotation, 0, Time.deltaTime * rotationSpeed);
        else
            currentZRotation += movementValue.x * rotationSpeed * Time.deltaTime;
        currentZRotation = Mathf.Clamp(currentZRotation, minRotation, maxRotation);
        heliObject.localEulerAngles = new Vector3(0, 0, -currentZRotation);
    }
}
