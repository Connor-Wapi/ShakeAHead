using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Text durabilityText;
    [SerializeField] private BellDurablity bellDurability;
    
    void Update()
    {
        durabilityText.text = "Bell durability :: " + bellDurability.Durability;
    }
}
