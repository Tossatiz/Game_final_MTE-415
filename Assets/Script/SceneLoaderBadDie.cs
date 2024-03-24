using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderBadDie : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void LoadBadEnd()
    {
        SceneManager.LoadScene("BadEndDie");
    }
}
