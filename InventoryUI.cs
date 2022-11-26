using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI CoinText;

    // Start is called before the first frame update
    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinText(PlayerInventory playerInventory)
    {
        CoinText.text = playerInventory.NumberOfCoin.ToString();
    }
}