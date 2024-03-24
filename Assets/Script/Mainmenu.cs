using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
    {
        SceneManager.LoadScene("Map_fini_123");
    }

    public void Quit()
    {
        Application.Quit();;
        Debug.Log("Player Has Quit The Game");
    }
}
