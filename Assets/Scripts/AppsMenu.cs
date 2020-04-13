using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Transform canvac;
    [SerializeField] private GameObject exampleAppProgram;
    [SerializeField] private Text nameGame;
    [SerializeField] private List<GameObject> listAppProgram;
    private float tranformApps = 400;

    public void Start()
    {
        sizeMenu();
    }

    private void sizeMenu()
    {
        RectTransform size = mainMenu.GetComponent<RectTransform>();
        if (listAppProgram.Count * tranformApps > size.sizeDelta.y)
        {
            size.sizeDelta = new Vector2(800, size.sizeDelta.y + tranformApps * (listAppProgram.Count - 3));
        }
        TransformApps();
    }

    private void TransformApps()
    {
        mainMenu.transform.position = new Vector3(240f, mainMenu.transform.position.y - (tranformApps / 2 * (listAppProgram.Count - 3)), 0f);
        nameGame.transform.position = new Vector3(240f, nameGame.transform.position.y + (tranformApps / 4 * (listAppProgram.Count - 3)), 0f);
        listAppProgram[0].transform.position = new Vector3(240f,nameGame.transform.position.y-150f,0f);
        for (int i = 1; i < listAppProgram.Count; i++)
        {
            float newPositionY = listAppProgram[0].transform.position.y - (tranformApps/2 * (listAppProgram.Count - 3) * i);
            listAppProgram[i].transform.position = new Vector3(240f, newPositionY, 0f);
        }
    }
}
