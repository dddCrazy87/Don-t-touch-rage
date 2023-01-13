using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void replay() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
