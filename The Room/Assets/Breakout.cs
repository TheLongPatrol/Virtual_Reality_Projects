using UnityEngine;
using UnityEngine.InputSystem;
public class Breakout : MonoBehaviour
{
    public InputActionReference action;
    private bool broke_out;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.broke_out = false;
        action.action.Enable();
        action.action.performed += (ctx) => {
            this.broke_out = !this.broke_out;
            if (this.broke_out)
                transform.position = new Vector3(-30,-15,-15);
            else
                transform.position = new Vector3(0,0.5f,-7.2f);
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
