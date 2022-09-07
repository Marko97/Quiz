using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashToGame : MonoBehaviour
{
    public GameObject bgm;
    public GameObject splashBlack;
    public GameObject splashText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        yield return new WaitForSeconds(4);
        bgm.SetActive(true);
        yield return new WaitForSeconds(1);
        splashText.SetActive(false);
        splashBlack.SetActive(false);
    }
    

    public void Exit()
    {
        Application.Quit();
    }

}
