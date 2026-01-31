using UnityEngine;
public class LightScript : MonoBehaviour
{
    public Light point_light;
    private int num_clicked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.point_light = GetComponent<Light>();
        this.num_clicked = 0;
        this.point_light.color= Color.red;
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
