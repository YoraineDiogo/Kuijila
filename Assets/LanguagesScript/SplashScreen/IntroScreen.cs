/*Developed and provided by SpeedTutor - www.speed-tutor.com*/
//slightly modified by me
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroScreen : MonoBehaviour
{
    public Image splashImage;
	public Image backSplashImage;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
		backSplashImage.canvasRenderer.SetAlpha(3.0f);

        FadeIn();
        yield return new WaitForSeconds(0.5f);
        FadeOut();
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
		backSplashImage.CrossFadeAlpha(0f, 0f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
		backSplashImage.CrossFadeAlpha(2.0f, 2.5f, false);
    }
}
