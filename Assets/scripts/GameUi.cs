
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        hienthithoigiangame();
    }

    public void hienthithoigiangame()
    {
        timeText.SetText(Mathf.FloorToInt(GameManager.instance.thoigianchophepvedich).ToString());
    }

    public void ChoiLai()
    {
        SceneManager.LoadScene("Game");
    }

    public void VeMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
