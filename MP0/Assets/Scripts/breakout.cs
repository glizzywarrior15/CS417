using UnityEngine;
using UnityEngine.InputSystem;

public class breakout : MonoBehaviour
{
    public InputActionReference action;
    bool escaped = false;

    void OnEnable()
    {
        if (action != null)
            action.action.Enable();
    }

    void OnDisable()
    {
        if (action != null)
            action.action.Disable();
    }

    void Update()
    {
        if (action != null && action.action.WasPressedThisFrame())
        {
            transform.Translate(0, escaped ? -17 : 17, 0);
            escaped = !escaped;
        }
    }
}
