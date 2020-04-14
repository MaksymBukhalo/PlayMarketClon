using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
	[SerializeField] private GameObject mainPage;
	[SerializeField] private ListApp listApp;
	[SerializeField] private Transform parent;



	public void ClicLoadApp()
	{
		mainPage.transform.position = new Vector3(-1000f, 0f);
		for (int i = 0; i < listApp.appList.Count; i++)
		{
			if (gameObject.name == listApp.appList[i].name)
			{
				Instantiate(listApp.appList[i], parent);
			}
		}

	}
}
