using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
	[SerializeField] private GameObject destroyObject;

	public void ReturnFromMenu()
	{
		GameObject.Find("MainMenu").transform.position = new Vector3(GameObject.Find("Canvas").transform.position.x, 0f);
		Destroy(destroyObject);
	}
}
