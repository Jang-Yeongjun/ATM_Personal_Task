using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("added");
        ButtonScript.onDeposit += HandleDepositClick;
        ButtonScript.onWithdrawal += HandleWithdrawalClick;
    }

    private void OnDisable()
    {
        Debug.Log("disadded");
        ButtonScript.onDeposit -= HandleDepositClick;
        ButtonScript.onWithdrawal -= HandleWithdrawalClick;
    }

    private void HandleDepositClick()
    {
        Debug.Log("Deposited");
    }

    private void HandleWithdrawalClick()
    {
        Debug.Log("클릭됨, 출금 완료!");
    }
}
