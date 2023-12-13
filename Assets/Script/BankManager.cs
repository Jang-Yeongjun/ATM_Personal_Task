using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    TextChanger textChanger;
    private void Start()
    {
        textChanger = GetComponent<TextChanger>();
    }
    private void OnEnable()
    {
        ButtonScript.onDeposit += HandleDepositClick;
        ButtonScript.onWithdrawal += HandleWithdrawalClick;
    }

    private void OnDisable()
    {
        ButtonScript.onDeposit -= HandleDepositClick;
        ButtonScript.onWithdrawal -= HandleWithdrawalClick;
    }

    private void HandleDepositClick()
    {
        textChanger.ChangeDepositText();
    }

    private void HandleWithdrawalClick()
    {
        textChanger.ChangeWithdrawalText();
    }

}
