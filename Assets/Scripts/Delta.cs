using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delta : Covid19
{

    private void Awake()
    {
       this.initiateProperty(20, "Delta");
    }
    private void Start()
    {
        base.ShowInformation();
        
    }
    public override void Infect(string animal)
    {

        base.Infect(animal);
    }
    public override void Infect(string people, int age)
    {



        base.Infect(people, age);
    }
}
