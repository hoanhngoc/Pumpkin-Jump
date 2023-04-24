using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    private int coin;

    [SerializeField] Text txtCoin;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void AddCoin(int value)
    {
        coin += value;
        SaveCoin();
        LoadCoin();
    }

    private void Start()
    {
        LoadCoin();
    }

    void LoadCoin()
    {
        coin = PlayerPrefs.GetInt("coin");
        txtCoin.text = coin.ToString();
    }

    void SaveCoin()
    {
        PlayerPrefs.SetInt("coin", coin);
    }
}
