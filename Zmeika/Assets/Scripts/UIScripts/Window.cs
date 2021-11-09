using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    private string _name ="Dick";
    protected string GetName()
    {
        string name = _name;
        return name;
    }
    bool IsActivated { get; set; }
    public virtual void Show() 
    {
        gameObject.SetActive(true);
    }
 
}
