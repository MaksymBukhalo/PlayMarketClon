using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSizeMainMenu : MonoBehaviour
{
	[SerializeField] private GameObject _mainMenu;
	[SerializeField] private Transform _parentalCanvas;
	[SerializeField] private Text _nameGame;
	[SerializeField] private List<GameObject> _listAppProgram;

	private float _appDistanceTransform = 400;

	public void Start()
	{
		SizeMenu();
	}

	private void SizeMenu()
	{
		RectTransform size = _mainMenu.GetComponent<RectTransform>();
		if (_listAppProgram.Count * _appDistanceTransform > size.sizeDelta.y)
		{

			size.sizeDelta = new Vector3(800f, size.sizeDelta.y + _appDistanceTransform * (_listAppProgram.Count - 3));
		}
		TransformApps();
	}

	private void TransformApps()
	{
		_mainMenu.transform.position = new Vector3(_parentalCanvas.position.x, _mainMenu.transform.position.y - (_appDistanceTransform / 2 * (_listAppProgram.Count - 3)));
		_nameGame.transform.position = new Vector3(0f, _nameGame.transform.position.y + (_appDistanceTransform / 4 * (_listAppProgram.Count - 3)));
		_listAppProgram[0].transform.position = new Vector3(240f, _nameGame.transform.position.y - 150f, 0f);
		for (int i = 1; i < _listAppProgram.Count; i++)
		{
			float newPositionY = _listAppProgram[0].transform.position.y - (_appDistanceTransform / 2 * (_listAppProgram.Count - 3) * i);
			_listAppProgram[i].transform.position = new Vector3(240f, newPositionY, 0f);
		}
	}
}
