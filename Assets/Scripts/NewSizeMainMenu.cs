using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSizeMainMenu : MonoBehaviour
{
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private Transform parentalCanvas;
	[SerializeField] private Text nameGame;
	[SerializeField] private List<GameObject> listAppProgram;

	private float appDistanceTransform = 400;

	public void Start()
	{
		sizeMenu();
	}

	private void sizeMenu()
	{
		RectTransform size = mainMenu.GetComponent<RectTransform>();
		if (listAppProgram.Count * appDistanceTransform > size.sizeDelta.y)
		{

			size.sizeDelta = new Vector3(800f, size.sizeDelta.y + appDistanceTransform * (listAppProgram.Count - 3));
		}
		TransformApps();
	}

	private void TransformApps()
	{
		mainMenu.transform.position = new Vector3(parentalCanvas.position.x, mainMenu.transform.position.y - (appDistanceTransform / 2 * (listAppProgram.Count - 3)));
		nameGame.transform.position = new Vector3(0f, nameGame.transform.position.y + (appDistanceTransform / 4 * (listAppProgram.Count - 3)));
		listAppProgram[0].transform.position = new Vector3(240f, nameGame.transform.position.y - 150f, 0f);
		for (int i = 1; i < listAppProgram.Count; i++)
		{
			float newPositionY = listAppProgram[0].transform.position.y - (appDistanceTransform / 2 * (listAppProgram.Count - 3) * i);
			listAppProgram[i].transform.position = new Vector3(240f, newPositionY, 0f);
		}
	}
}
