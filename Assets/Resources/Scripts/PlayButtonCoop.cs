using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonCoop : MonoBehaviour
{
    public void PlayGameCoop()
    {
        SceneManager.LoadScene("GameSceneCoop");
    }

}
