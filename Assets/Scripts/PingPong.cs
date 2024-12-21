using UnityEngine;

public class PingPong : MonoBehaviour
{
    public enum Axis { X, Z }  
    public Axis movementAxis = Axis.X; 

    public float speed = 2f;       
    public float distance = 3f;     

    private Vector3 startPosition;  

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float pingPongValue = Mathf.PingPong(Time.time * speed, distance);

        Vector3 newPosition = startPosition;
        if (movementAxis == Axis.X)
        {
            newPosition.x = startPosition.x + pingPongValue;
        }
        else if (movementAxis == Axis.Z)
        {
            newPosition.z = startPosition.z + pingPongValue;
        }

        transform.position = newPosition;
    }
}
