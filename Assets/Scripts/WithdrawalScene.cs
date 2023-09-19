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

        // ����� �ݾ��� ���¿� ���� ������ Ŭ��
        if (withdrawMoney < amount)
        {
            InvalidWithdrawal();  // ��� ��ȿȭ�ϰ� �˾� Ȱ��ȭ
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
            // �ƹ��͵� �Է����� �ʾ��� �� PleaseWritePanel�� Ȱ��ȭ
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
                // �������� ��� ó��
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
