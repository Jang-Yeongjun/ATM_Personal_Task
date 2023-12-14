using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class ProcessData : MonoBehaviour
{
    public TextMeshProUGUI _cashText;
    public TextMeshProUGUI _balanceText;
    public void DepositProcess()
    {
        DataManager.instance.LoadData();

    }
}
