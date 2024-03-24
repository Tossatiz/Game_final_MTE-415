using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Unity.VisualScripting;

public class videoGoodend : MonoBehaviour
{

    VideoPlayer video;
    public GameObject iogomenu;
    public GameObject bg1;
    

    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        iogomenu.SetActive(false);
        bg1.SetActive(false);
    /*    start.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        quit.gameObject.SetActive(false); */
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || (video.frame > 0 && video.isPlaying == false))
        {
            video.gameObject.SetActive(false);
            iogomenu.SetActive(true);
           /* bg1.SetActive(true);
            start.gameObject.SetActive(true);
            credits.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);*/

        }
    }
}
