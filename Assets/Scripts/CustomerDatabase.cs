using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomerCustomClass
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;


    public CustomerCustomClass(string firstName, string lastName, int age, string gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

}


public class CustomerDatabase : MonoBehaviour
{
    public CustomerCustomClass[] customers;
    

    // Start is called before the first frame update
    void Start()
    {
        customers[1] = new CustomerCustomClass("Joe", "Blow", 34, "Male", "Banker");
        customers[2] = new CustomerCustomClass("Jess", "Winkle", 28, "Female", "Lawyer");
        customers[3] = new CustomerCustomClass("John", "Smith", 52, "Male", "Waiter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
