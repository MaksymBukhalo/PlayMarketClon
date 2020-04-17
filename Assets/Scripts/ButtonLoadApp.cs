using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonLoadApp : MonoBehaviour
{
	[SerializeField] private GameObject mainMenuPage;
	[SerializeField] private ListApp listApps;
	[SerializeField] private Transform parentalPageApp;



	public void ClicLoadApp()
	{
		mainMenuPage.transform.position = new Vector3(-1000f, 0f);
		for (int i = 0; i < listApps.appList.Count; i++)
		{
			if (gameObject.name == listApps.appList[i].name)
			{
				Instantiate(listApps.appList[i], parentalPageApp);
			}
		}

	}
}
