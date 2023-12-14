using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class ScreenChanger : MonoBehaviour
{
    public TextMeshProUGUI _firstText;
    public TextMeshProUGUI _secondText;
    public TextMeshProUGUI _thirdText;
    public TextMeshProUGUI _fourthText;
    public GameObject _button;
    public float fontSize = 36f;
    public void ChangeButtonScript(int buttonValue)
    {
        if (_button.CompareTag("bank"))
        {
            ButtonText();
            if (buttonValue == 10000)
            {
                _button.tag = "remittance";
            }
            else if (buttonValue == 50000)
            {
                _button.tag = "deposit";
            }
            else if (buttonValue == 100000)
            {
                _button.tag = "loan";
            }
            else if (buttonValue == 0)
            {
                _button.tag = "withdrawal";
            }
        }
    }
    public void ButtonText()
    {
        _firstText.text = "10,000";
        _secondText.text = "50,000";
        _thirdText.text = "100,000";
        _fourthText.text = "직접입력";
        _firstText.fontSize = fontSize - 16f;
        _secondText.fontSize = fontSize - 16f;
        _thirdText.fontSize = fontSize - 16f;
        _fourthText.fontSize = fontSize - 16f;
    }

    public void BankMainScreen()
    {
        _firstText.text = "송금";
        _secondText.text = "예금";
        _thirdText.text = "대출";
        _fourthText.text = "출금";
        _firstText.fontSize = fontSize;
        _secondText.fontSize = fontSize;
        _thirdText.fontSize = fontSize;
        _fourthText.fontSize = fontSize;
        _button.tag = "bank";
    }
}
