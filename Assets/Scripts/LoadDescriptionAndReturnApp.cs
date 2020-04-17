using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDescriptionAndReturnApp : MonoBehaviour
{
	public GameObject loadDescription;
	public GameObject appsMenu;

	public void LoadDescriptionPage()
	{
		appsMenu.SetActive(false);
		loadDescription.SetActive(true);
	}

	public void ReturnAppPage()
	{
		loadDescription.SetActive(false);
		appsMenu.SetActive(true);
	}

}
