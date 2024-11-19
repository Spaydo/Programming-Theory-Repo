using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    protected override void Click()
    {
        Debug.Log(this.objName + " was clicked, color is:" + this.color);
    }

    protected override void DisplayText()
    {
        Debug.Log("圓形刷新畫面上物件");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.objName = "Sphere";
        this.color = Color.green;
    }
}
