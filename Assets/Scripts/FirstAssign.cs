using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssign : MonoBehaviour
{
    // Start is called before the first frame update

    void bolenleriBul(int sayi1 , int sayi2)
    {

        ArrayList liste = new ArrayList();
        ArrayList liste2 = new ArrayList();
        ArrayList liste3 = new ArrayList();
        ArrayList liste4 = new ArrayList();
        ArrayList liste5 = new ArrayList();
        for ( int i = sayi1; i <= sayi2; i++)
        {
            liste.Add(i);
            if(i%2 == 0)
            {
                liste2.Add(i);
            }
            if(i%3 == 0)
            {
                liste3.Add(i);
            }
            if (i % 4 == 0)
            {
                liste4.Add(i);
            }
            if (i % 5 == 0)
            {
                liste5.Add(i);
            }
        }

        string tum = "";
        foreach (int eleman in liste)
        {
            tum += " - " + eleman ;
        }
        string ikiye = "";
        foreach (int eleman in liste2)
        {
            ikiye += " - " + eleman;
        }
        string uce = "";
        foreach (int eleman in liste3)
        {
            uce += " - " + eleman;
        }
        string dorde = "";
        foreach (int eleman in liste4)
        {
            dorde += " - " + eleman;
}
            string bese = "";
            foreach (int eleman in liste5)
            {
                bese += " - " + eleman;
            }
        
        print("Tum liste = "+tum);
        print("Ikiye Bolunenler = " + ikiye);
        print("Uce Bolunenler = " + uce);
        print("Dorde Bolunenler = " + dorde);
        print("Bese Bolunenler = " + bese);






    }
    void Start()
    {
        bolenleriBul(10, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
