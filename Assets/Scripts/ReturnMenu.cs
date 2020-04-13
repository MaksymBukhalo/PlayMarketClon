using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    public GameObject destroyObject;

    public void ReturnFromMenu()
    {
        GameObject.Find("MainMenu").transform.position = new Vector3(240f,0f);
        Destroy(destroyObject);   
    }
}
