using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] string audioName;
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void PlayAudio()
    {
        audioManager.PlaySound("Dialogue", audioName, transform.position,false);
    }
}
