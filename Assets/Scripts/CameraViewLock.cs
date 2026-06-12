using UnityEngine;
using UnityEngine.UIElements;

public class CameraViewLock : MonoBehaviour
{
    public GameObject PlayerCar;
    public float yAxis = 10f;
    public float zAxis = 11f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.position =  new Vector3(
            PlayerCar.transform.position.x, 
            PlayerCar.transform.position.y + yAxis,
            PlayerCar.transform.position.z + zAxis);
        
    }
}
