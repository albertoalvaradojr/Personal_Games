using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private string[] cars = new string[16];

    private void Start()
    {
        LoadData();
    }
    
    //Saves car selected, money and the cost of each car
    public void SaveData(int i, int j, int money, int cost)
    {
        PlayerPrefs.SetInt(cars[i], j);
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("Cost", cost);
    }

    public void LoadData()
    {
        for(int i = 0; i < cars.Length; i++) cars[i] = i.ToString();
    }

    public bool CheckData(int i)
    {
        if (PlayerPrefs.GetInt(cars[i]) == 1) return true;
        return false;
    }
}
