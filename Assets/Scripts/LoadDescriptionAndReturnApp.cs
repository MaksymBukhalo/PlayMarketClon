using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDescriptionAndReturnApp : MonoBehaviour
{
	public GameObject LoadDescription;
	public GameObject AppsMenu;

	public void LoadDescriptionPage()
	{
		AppsMenu.SetActive(false);
		LoadDescription.SetActive(true);
	}

	public void ReturnAppPage()
	{
		LoadDescription.SetActive(false);
		AppsMenu.SetActive(true);
	}

}
