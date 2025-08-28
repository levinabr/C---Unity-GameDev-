using UnityEngine;

public class test : MonoBehaviour
{
    GameObject obj;
    public GameObject [] shapes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { //the code below obtains gameobjects in the name shape and destroy each with the help of foreach loop
       foreach(GameObject shape in shapes){
        Destroy (shape);//destroys
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
   
}
