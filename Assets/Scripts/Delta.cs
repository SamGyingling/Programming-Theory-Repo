using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delta : Covid19
{

    private void Awake()
    {
      initiateProperty(20, "Delta");
    }
    
    public override void OnclickPrintInfo()
    {
      
        GameManager.Instance.printInfo("I will do something different");
    }
}
