using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covid19 : MonoBehaviour
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
    private void Start()
    {
        ShowInformation();
    }

    public void initiateProperty(int _hp, string _name)
    {
        this.myName = _name;
        this.hp = _hp;
    }
    public virtual void  Infect(string animal)
    {
        // it will first check what kind of animal it infected and in accordance to adjust power
        // and print the symptoms

    }
    public virtual void Infect(string people, int age)
    {
        // it will first check what age of people  it infected and in accordance to adjust power
        // and print the symptoms
    }

    public void ShowInformation()
    {
        //when click on the gameobject a popup window shows all the imformation

        print("this is" + _myName + "with" + _hp + "HP");

    }

    
}
