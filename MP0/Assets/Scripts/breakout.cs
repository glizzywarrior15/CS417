using UnityEngine;

public class breakout : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    bool escaped = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !escaped)
        {
            transform.Translate(0, 17, 0);
            escaped = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && escaped)
        {
            transform.Translate(0, -17, 0);
            escaped = false;
        }
    }
}
