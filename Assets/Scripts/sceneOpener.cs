using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneOpener : MonoBehaviour
{

    public void
    ShowFlow1()
    {
        SceneManager.LoadScene("Particle_Flow");
    }

    public void
    ShowMainScreen()
    {
        SceneManager.LoadScene("Main");
    }

    public void
    showFlow2()
    {
        SceneManager.LoadScene("linearParticleFlow");
    }

}
