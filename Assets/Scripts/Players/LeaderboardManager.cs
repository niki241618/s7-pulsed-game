using Players;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{
    public Transform Top3;
    public Transform AllPlayers;
    public GameObject PlayerLeaderboard;
    private List<Player> PlayerLists = new List<Player>();
    private Player[] PlayerList;

    private void Start()
    {
        //Use this code when you are done with testing to see if player data is pulled

        //PlayerLists = PlayersManager.Instance.Players;


        //This is test code, use it to check whether the leaderboard loads in correctly

        Player player1 = new Player("Yoana");
        player1.Score = UnityEngine.Random.Range(1, 25);
        Player player2 = new Player("Nikolay");
        player2.Score = UnityEngine.Random.Range(1, 25);
        Player player3 = new Player("Stoyan");
        player3.Score = UnityEngine.Random.Range(1, 25);
        Player player4 = new Player("Martin");
        player4.Score = UnityEngine.Random.Range(1, 25);
        PlayerLists.Add(player1);
        PlayerLists.Add(player2);
        PlayerLists.Add(player3);
        PlayerLists.Add(player4);
        PlayerLists.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
        PlayerList = PlayerLists.ToArray();

        DisplayTopThree();
        PopulateScrollView();

    }
    void DisplayTopThree()
    {
        int count = Math.Min(3, PlayerList.Length);
        for (int i =0; i < count; i++)
        {
            TMP_Text PlayerText = Top3.GetChild(i).Find("PlayerName").GetComponent<TMP_Text>();
            PlayerText.text = PlayerList[i].Name;
        }
    }

    void PopulateScrollView()
    {
        int count = PlayerList.Length;
        for (int i = 0; i < count; i++)
        {
            GameObject entry = Instantiate(PlayerLeaderboard, AllPlayers);
            TMP_Text rankText = entry.transform.Find("Rank").GetComponent<TMP_Text>();
            TMP_Text nameText = entry.transform.Find("Name").GetComponent<TMP_Text>();
            TMP_Text scoreText = entry.transform.Find("Score").GetComponent<TMP_Text>();

            rankText.text = $"{i + 1}";
            nameText.text = PlayerList[i].Name;
            scoreText.text = $"{PlayerList[i].Score}";
            entry.SetActive(true);
        }
    }
}
