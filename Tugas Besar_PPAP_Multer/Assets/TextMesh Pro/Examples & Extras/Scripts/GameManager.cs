using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PlayGame()
    {
        // Panggil fungsi untuk memulai permainan
        SceneManager.LoadScene("DemoScene"); // Ganti "GameScene" dengan nama scene permainan Anda
    }

    public void QuitGame()
    {
        // Panggil fungsi untuk keluar dari game
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
