using UnityEngine;
using UnityEngine.InputSystem;
public class LightScript : MonoBehaviour
{
    public Light point_light;
    private bool switch_on;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.point_light = GetComponent<Light>();
        this.switch_on = false;
        action.action.Enable();
        action.action.performed += (ctx) => {
            if (this.switch_on)
                this.point_light.color = Color.green;
            else
                this.point_light.color = Color.red;
            this.switch_on = !this.switch_on;
        };
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown("l") && this.num_clicked % 2 == 0){
        //     this.point_light.color = Color.green;
        //     this.num_clicked+=1;
        // } else if (Input.GetKeyDown("l")) {
        //     this.point_light.color = Color.blue;
        //     this.num_clicked+=1;
        // }
    }
}
