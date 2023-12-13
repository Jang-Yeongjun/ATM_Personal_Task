using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI _firstText;
    public TextMeshProUGUI _secondText;
    public TextMeshProUGUI _thirdText;
    public TextMeshProUGUI _fourthText;
    public GameObject _firstButton;
    public GameObject _secondButton;
    public GameObject _thirdButton;
    public GameObject _fourthButton;
    public float fontSize = 36f;
    public void ChangeDepositText()
    {
        _firstText.text = "10,000";
        _secondText.text = "50,000";
        _thirdText.text = "100,000";
        _fourthText.text = "流立涝仿";
        _firstButton.tag = "deposit";
        _secondButton.tag = "deposit";
        _thirdButton.tag = "deposit";
        _fourthButton.tag = "deposit";
        _firstText.fontSize = fontSize - 16f;
        _secondText.fontSize = fontSize - 16f;
        _thirdText.fontSize = fontSize - 16f;
        _fourthText.fontSize = fontSize - 16f;

    }
    public void ChangeWithdrawalText()
    {
        _firstText.text = "10,000";
        _secondText.text = "50,000";
        _thirdText.text = "100,000";
        _fourthText.text = "流立涝仿";
        _firstButton.tag = "withdrawal";
        _secondButton.tag = "withdrawal";
        _thirdButton.tag = "withdrawal";
        _fourthButton.tag = "withdrawal";
        _firstText.fontSize = fontSize - 16f;
        _secondText.fontSize = fontSize - 16f;
        _thirdText.fontSize = fontSize - 16f;
        _fourthText.fontSize = fontSize - 16f;

    }
}
