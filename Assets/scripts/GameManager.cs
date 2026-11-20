
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float thoigianchophepvedich = 30f;
    public bool ketthucgame = false;
    public bool winGame = false;

    private static GameManager _instance;

    public GameObject gameoverobject;
    public GameObject timeoverobject;
    public GameObject winGameObject;

    [SerializeField]
    private float thoigianhoikhiquacheckpoint = 31f;

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject gameManagerObject = new GameObject("GameManager");
                    _instance = gameManagerObject.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }

    private void Update()
    {
        if (!ketthucgame)
        {
            thoigianchophepvedich -= Time.deltaTime;

            Debug.Log(thoigianchophepvedich);

            if (thoigianchophepvedich <= 0)
            {
                if (timeoverobject != null)
                {
                    timeoverobject.SetActive(false);
                }

                if (gameoverobject != null)
                {
                    gameoverobject.SetActive(true);
                }

                KetThucGame();
            }
        }

        if (winGame)
        {
            if (timeoverobject != null)
            {
                timeoverobject.SetActive(false);
            }

            if (winGameObject != null)
            {
                winGameObject.SetActive(true);
            }
        }
    }

    public void KetThucGame()
    {
        ketthucgame = true;
    }

    public void quaCheckPoin()
    {
        if (!ketthucgame)
        {
            thoigianchophepvedich = thoigianhoikhiquacheckpoint;
        }
    }

    public void quawinpoint()
    {
        if (!ketthucgame)
        {
            winGame = true;
        }
    }
}
