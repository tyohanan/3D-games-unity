using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polymorphism : MonoBehaviour
{
    private void Start()
    {
        polymorphism dragon = new polymorphism();
        dragon.Attack();

        polymorphism dragon1 = new redDragon();
        dragon1.Attack();

        polymorphism dragon2 = new blueDragon();
        dragon2.Attack();

        polymorphism dragon3 = new greenDragon();
        dragon3.Attack();
    }

    public virtual void Attack()
    {
        print("this is Dragon");
    }
}
//end of polymorphism class

public class redDragon : polymorphism
{
    public override void Attack()
    {
        print("this is redDragon");
    }
}

public class blueDragon : polymorphism
{
    public override void Attack()
    {
        print("this is blueDragon");
    }
}

public class greenDragon : polymorphism
{
    public override void Attack()
    {
        print("this is greenDragon");    }
}