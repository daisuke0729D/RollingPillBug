using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;


public class MainGameStateManager : MonoBehaviour
{
    // Start is called before the first frame update
    public enum GameStates
    {
        GameInit = 0,
        GameStart,
        GameMain,
        GameOver
    }

    public GameStates GameState = GameStates.GameInit;

    /// <summary>
    /// �X�^�[�g���̃J�E���g�_�E���p��Text�R���|�[�l���g
    /// </summary>
    public TextMeshProUGUI StartTimeText;

    /// <summary>
    /// �J�E���g�_�E���̕b��
    /// </summary>
    public float CountDownSec = 3f;

    // Update is called once per frame
   private void Update()
    {
        switch (GameState)
        {
            case GameStates.GameInit:

                GameState = GameStates.GameStart;
                break;

            case GameStates.GameStart:

                CountDownSec -= Time.deltaTime;

                StartTimeText.text = Mathf.CeilToInt(CountDownSec).ToString();

                if (CountDownSec < 0)
                {
                    StartTimeText.text = "GO";
                }

                if (CountDownSec < -1)
                {
                    StartTimeText.text = string.Empty;

                    GameState = GameStates.GameMain;
                }
                break;

            case GameStates.GameMain:

                break;

            case GameStates.GameOver:

                break;
        }
    }
}
