using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    string firstname;
    string lastname;
    int age;

int num1;
int num2;

int total;

    // Start is called before the first frame update
    void Start()
    {
    //   firstname = "Bob";

    //   lastname = "Neon";

    //   age = 90;

      Customer(firstname, lastname, age);
      CalcAdd(11,23);
    }
    
    int CalcAdd (int n1, int n2)
    {
        Debug.Log("Number 1 =" + n1+"Number 2=" + n2);
        total = n1 + n2;

        Debug.Log(total);
        return total;
      

    }



    void Customer(string fname, string lname, int a)
    {
        Debug.Log(fname + "" + lname + "" + a);
    }
    
}
