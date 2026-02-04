using UnityEngine;

public class OrbitingMoon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object about the Y-axis using deltaTime
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
