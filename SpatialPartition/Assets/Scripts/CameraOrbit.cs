using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target; 
    public float rotationSpeed = 10f;

    void Update()
    {
        
        transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);

        
        transform.LookAt(target.position);
    }
}
