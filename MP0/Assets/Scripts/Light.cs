using UnityEngine;

public class Light : MonoBehaviour
{
    public new UnityEngine.Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<UnityEngine.Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            light.color = Color.red;
        }
    }
}
