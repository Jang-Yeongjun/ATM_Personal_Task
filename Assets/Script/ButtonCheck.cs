using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    ButtonScript buttonScript;

    private void Start()
    {
        buttonScript = GetComponent<ButtonScript>();
    }
    public void OnClick()
    {
        if(gameObject.CompareTag("Deposit") )
        {
            buttonScript.OnDeposit();
        }
        else if(gameObject.CompareTag("Withdrawal"))
        {
            buttonScript.OnWithdrawal();
        }
        else if (gameObject.CompareTag("Remittance"))
        {
            Debug.Log("Remittancing");
        }
        else if (gameObject.CompareTag("Loan"))
        {
            Debug.Log("Loanning");
        }
        else if (gameObject.CompareTag("deposit"))
        {
            Debug.Log("deposit code");
        }
        else if (gameObject.CompareTag("withdrawal"))
        {
            Debug.Log("withdrawal Code");
        }
    }
}
