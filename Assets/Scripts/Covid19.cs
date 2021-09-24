using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Covid19 : MonoBehaviour, Imyinterface
{
    
    private int _hp;
    protected int hp
    {
        get
        {
            return _hp;
                
        }
        set
        {
            _hp = value;
        }
    }

    private int _power;
    protected int power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }

    private string _myName;
    protected string myName
    {
        get
        {
            return _myName;
        }
        set
        {
            _myName = value;
        }
    }


    private void Awake()
    {
        initiateProperty(10, "Covid19");
    }
 
  
    public void initiateProperty(int _hp, string _name)
    {
        myName = _name;
        hp = _hp;
    }
   
    public virtual void OnclickPrintInfo()
    {
        //when click on the gameobject a popup window shows all the imformation
        string _t = "this is" + myName + "with" + hp + "HP";
        GameManager.Instance.printInfo(_t);
    }

}
