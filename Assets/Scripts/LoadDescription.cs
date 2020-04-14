using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDescription : MonoBehaviour
{
	public GameObject loadDescription;
	public GameObject appsMenu;

	public void LoadDescriptionPage()
	{
		appsMenu.SetActive(false);
		loadDescription.SetActive(true);
	}

	public void ReturnApp()
	{
		loadDescription.SetActive(false);
		appsMenu.SetActive(true);
	}

}
