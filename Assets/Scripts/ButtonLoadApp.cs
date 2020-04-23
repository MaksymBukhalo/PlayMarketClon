using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonLoadApp : MonoBehaviour
{
	[SerializeField] private GameObject _mainMenuPage;
	[SerializeField] private ListApp _listApps;
	[SerializeField] private Transform _parentalPageApp;



	public void ClicLoadApp()
	{
		_mainMenuPage.transform.position = new Vector3(-1000f, 0f);
		for (int i = 0; i < _listApps.AppList.Count; i++)
		{
			if (gameObject.name == _listApps.AppList[i].name)
			{
				Instantiate(_listApps.AppList[i], _parentalPageApp);
			}
		}

	}
}
