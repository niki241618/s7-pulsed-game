using System;
using GameScripts;
using Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnScript : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text questionText;
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Button doneBtn;
    [SerializeField] private Button passBtn;

    private SceneTransition sceneTransition;
    private Turn turn;
    private void Awake()
    {
        turn = PlayersManager.Instance.CurrentRound.Turn;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneTransition = GetComponent<SceneTransition>();
        playerNameText.text = turn.Player.Name;
        questionText.text = turn.Question.Text;
        SetBackgroundForCategory();
        
        doneBtn.onClick.AddListener(() =>
        {
            turn.Player.Score += turn.Question.Points;
            sceneTransition.ChangeScene("Select Category Scene");
        });
        
        passBtn.onClick.AddListener(() =>
        {
            sceneTransition.ChangeScene("Select Category Scene");
        });
    }

    private void SetBackgroundForCategory()
    {
        switch (turn.Question.Category)
        {
            case Category.MindMatters:
                backgroundImage.color = new Color32(248, 184, 217, 255);
                break;
            case Category.DeepDives:
                backgroundImage.color = new Color32(136, 206, 210, 255);
                break;
            case Category.ClicksAndGiggles:
                backgroundImage.color = new Color32(184, 217, 248, 255);
                break;
            case Category.FutureYou:
                backgroundImage.color = new Color32(215, 188, 232, 255);
                break;
        }
    }
}
