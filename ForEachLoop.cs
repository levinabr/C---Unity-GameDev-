using UnityEngine;

public class test : MonoBehaviour
{
   
   GameObject[] obj; // creates an array with name obj
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       obj = GameObject.FindGameObjectsWithTag("Enemys");// finds every game object with tags Enemys
       foreach(GameObject shape in obj ){ // finds the objects with the help of for earch loops by naming them shapes
            Destroy(shape); // Destroys it
       }
    }

 
        
   
}
