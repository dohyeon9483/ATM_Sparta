using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DepositScene : MonoBehaviour
{
    public Text CurrentMoneyText;
    public Text DepositMoneyText;
    public InputField InputMoneyField;
    public GameObject WarningPanel;
    public GameObject PleaseWritePanel;

    public void OnClick10000Button()
    {
        int amount = 10000;
        int currentMoney = int.Parse(CurrentMoneyText.text);

        // �Ա��� �ݾ��� ���ݺ��� Ŭ��
        if (currentMoney < amount)
        {
            InvalidDeposit();
            return; // �Ա� ��ȿȭ // InvalidDeposit���� Panel �˾� ������ ��.
        }

        // �Ա�
        currentMoney -= amount;

        // depositmoney�� ���ڿ��� parse�� int(����)�� ��ȯ. // ������ Money�� amount�� �߰�.
        int depositMoney = int.Parse(DepositMoneyText.text);
        depositMoney += amount;

        // TextUI ������Ʈ
        CurrentMoneyText.text = currentMoney.ToString();
        DepositMoneyText.text = depositMoney.ToString();
    }


    public void OnClick30000Button()
    {
        int amount = 30000;
        int currentMoney = int.Parse(CurrentMoneyText.text);

        if (currentMoney < amount)
        {
            InvalidDeposit();
            return; 
        }

        currentMoney -= amount;

        int depositMoney = int.Parse(DepositMoneyText.text);
        depositMoney += amount;

        CurrentMoneyText.text = currentMoney.ToString();
        DepositMoneyText.text = depositMoney.ToString();
    }

    public void OnClick50000Button()
    {
        int amount = 50000;
        int currentMoney = int.Parse(CurrentMoneyText.text);

        if (currentMoney < amount)
        {
            InvalidDeposit();
            return; 
        }

        currentMoney -= amount;

        int depositMoney = int.Parse(DepositMoneyText.text);
        depositMoney += amount;

        CurrentMoneyText.text = currentMoney.ToString();
        DepositMoneyText.text = depositMoney.ToString();
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
            int depositMoney = int.Parse(DepositMoneyText.text);

            if (currentMoney < amount)
            {
                InvalidDeposit();
            }
            else
            {
                // �������� �Ա� ó��
                currentMoney -= amount;
                depositMoney += amount;

                CurrentMoneyText.text = currentMoney.ToString();
                DepositMoneyText.text = depositMoney.ToString();

                InputMoneyField.text = "";

                if (currentMoney < 0)
                {
                    InvalidDeposit();
                }
            }
        }
    }




    public void InvalidDeposit()  // Invalid �޼���
    {
        WarningPanel.SetActive(true);   // panel Ȱ��ȭ
    }

    public void OnClickOKButton()
    {
        // Panel�� OK��ư Ŭ�� �� Panel ��Ȱ��ȭ.
        WarningPanel.SetActive(false);
        PleaseWritePanel.SetActive(false);
        InputMoneyField.text = "";  // �Է°� ����

    }

    public void GoBackToMainScene()  // �ڷΰ��� (���ξ� ����)
    {
        SceneManager.LoadScene("MainScene");
    }
}
