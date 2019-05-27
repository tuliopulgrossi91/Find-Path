using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("0 - Panel Manager"), Space(1), Header("1 - Btn Confirm"), Space(1), Header("2 - Settings"), Space(1), Header("3 - Levels"), Space(1), Header("4 - Credits")] public GameObject[] gameManager;
    [Header("0 - Text Panel"), Space(1), Header("1 - Text Credits")] public Text[] textManager;

    /// <summary>
    /// gameManager0 - panelManager
    /// gameManager1 - btnConfirm
    /// gameManager2 - settings
    /// gameManager3 - levels
    /// gameManager4 - credits
    /// 
    /// textManager0 - textPanel
    /// textManager1 - textCredits
    /// </summary>

    #region MENU MANAGER
    // check panel 
    public void PanelManager(bool b)
    {
        if (b == false)
        {
            gameManager[0].SetActive(!b); // true - on
        }
        else
        {
            gameManager[0].SetActive(!b); // false - off

            for (int i = 1; i < 5; i++)
            {
                gameManager[i].SetActive(!b);
            }
        }
    }

    public void ButtonsManager(int i)
    {
        switch (i)
        {
            case 0: // levels
                textManager[0].text = "Levels";
                gameManager[3].SetActive(true);
                break;
            case 1: // settings
                textManager[0].text = "Settings";
                gameManager[2].SetActive(true);
                break;
            case 2: // credits
                textManager[0].text = "Credits";
                gameManager[4].SetActive(true);
                textManager[1].text = "Development" + "\n" + "by" + "\n" + "Tulio Pulgrossi";
                break;
            case 3: // exit
                textManager[0].text = "Are you sure?";
                gameManager[1].SetActive(true);
                break;
            case 4: // corfirm
                Application.Quit();
                break;
            case 5: // load scene - level
                SceneManager.LoadScene(1);
                break;
        }
    } 
    #endregion
}