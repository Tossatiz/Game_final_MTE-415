using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuGood : MonoBehaviour
{
    // Start is called before the first frame update
    public void Mainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void Quit()
    {
        Application.Quit(); ;
        Debug.Log("Player Has Quit The Game");
    }
}
