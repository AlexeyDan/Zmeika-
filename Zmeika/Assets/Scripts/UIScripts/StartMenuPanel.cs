using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuPanel : Window 
{

    public override void Show()
    {
        
        Debug.Log(GetName());
        base.Show();
    }
}
