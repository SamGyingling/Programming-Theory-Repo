using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mu : Covid19
{


    private void Awake()
    {
        initiateProperty(20, "Gama");
    }
    private void Start()
    {

        ShowInformation();
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
