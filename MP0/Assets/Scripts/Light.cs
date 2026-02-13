using UnityEngine;
using UnityEngine.InputSystem;

public class Light : MonoBehaviour
{
    public new UnityEngine.Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference action;
    
    void Start()
    {
        light = GetComponent<UnityEngine.Light>();
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (action.action.WasPressedThisFrame())
        {
            light.color = Color.red;
        }
    }
}
