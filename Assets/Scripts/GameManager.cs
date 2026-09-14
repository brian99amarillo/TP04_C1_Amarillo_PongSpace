using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject player1;
    [SerializeField] public GameObject player2;
    [SerializeField] public GameObject ball;
    [SerializeField] public GameObject goalPlayer1;
    [SerializeField] public  GameObject goalPlayer2;
    [SerializeField] public TMP_Text scoreTextPlayer1;
    [SerializeField] public TMP_Text scoreTextPlayer2;
    [SerializeField] public TMP_Text timer;
}
