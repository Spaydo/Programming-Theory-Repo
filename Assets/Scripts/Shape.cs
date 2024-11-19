using Unity.VisualScripting;
using UnityEngine;

// INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string objName { get; protected set; }
    public Color color { get; protected set; }

    void OnMouseDown()
    {
        Click();
        DisplayText();
    }

    // ABSTRACTION
    protected abstract void Click();

    // POLYMOPHISM
    protected virtual void DisplayText()
    {
        Debug.Log("某物體觸發刷新畫面上物件");
    }
}
