using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WithdrawalScene : MonoBehaviour
{
    public Text CurrentMoneyText;
    public Text WithdrawMoneyText;
    public InputField InputMoneyField;
    public GameObject WarningPanel;
    public GameObject PleaseWritePanel;

    public void OnClick10000Button()
    {
        int amount = 10000;
        int currentMoney = int.Parse(CurrentMoneyText.text);
        int withdrawMoney = int.Parse(WithdrawMoneyText.text);

        // 출금할 금액이 계좌에 남은 돈보다 클때
        if (withdrawMoney < amount)
        {
            InvalidWithdrawal();  // 출금 무효화하고 팝업 활성화
            return; 
        }

        currentMoney += amount;
        withdrawMoney -= amount;

        CurrentMoneyText.text = currentMoney.ToString();
        WithdrawMoneyText.text = withdrawMoney.ToString();
    }

    public void OnClick30000Button()
    {
        int amount = 30000;
        int currentMoney = int.Parse(CurrentMoneyText.text);
        int withdrawMoney = int.Parse(WithdrawMoneyText.text);

        if (withdrawMoney < amount)
        {
            InvalidWithdrawal();
            return; 
        }

        currentMoney += amount;
        withdrawMoney -= amount;

        CurrentMoneyText.text = currentMoney.ToString();
        WithdrawMoneyText.text = withdrawMoney.ToString();
    }

    public void OnClick50000Button()
    {
        int amount = 50000;
        int currentMoney = int.Parse(CurrentMoneyText.text);
        int withdrawMoney = int.Parse(WithdrawMoneyText.text);


        if (withdrawMoney < amount)
        {
            InvalidWithdrawal();
            return; 
        }

        currentMoney += amount;
        withdrawMoney -= amount;

        CurrentMoneyText.text = currentMoney.ToString();
        WithdrawMoneyText.text = withdrawMoney.ToString();
    }





    public void OnClickInputButton()
    {
        string inputText = InputMoneyField.text;
        if (string.IsNullOrEmpty(inputText))
        {
            // 아무것도 입력하지 않았을 때 PleaseWritePanel을 활성화
            PleaseWritePanel.SetActive(true);
        }
        else
        {
            int amount = int.Parse(inputText);
            int currentMoney = int.Parse(CurrentMoneyText.text);
            int withdrawMoney = int.Parse(WithdrawMoneyText.text);

            if (withdrawMoney < amount)
            {
                InvalidWithdrawal();
            }
            else
            {
                // 정상적인 출금 처리
                currentMoney += amount;
                withdrawMoney -= amount;

                CurrentMoneyText.text = currentMoney.ToString();
                WithdrawMoneyText.text = withdrawMoney.ToString();

                InputMoneyField.text = "";
            }
        }
    }








    public void InvalidWithdrawal()
    {
        WarningPanel.SetActive(true);
    }

    public void OnClickOKButton()
    {
        WarningPanel.SetActive(false);
        PleaseWritePanel.SetActive(false);
        InputMoneyField.text = "";

    }
        public void GoBackToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
