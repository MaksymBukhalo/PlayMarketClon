using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "List", menuName = "ListApp/List")]

public class ListApp : ScriptableObject
{
	public List<GameObject> appList;
}
