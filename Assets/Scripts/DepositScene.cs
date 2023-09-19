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

        // 입금할 금액이 현금보다 클때
        if (currentMoney < amount)
        {
            InvalidDeposit();
            return; // 입금 무효화 // InvalidDeposit통해 Panel 팝업 나오게 함.
        }

        // 입금
        currentMoney -= amount;

        // depositmoney의 문자열을 parse로 int(정수)로 변환. // 계좌의 Money에 amount를 추가.
        int depositMoney = int.Parse(DepositMoneyText.text);
        depositMoney += amount;

        // TextUI 업데이트
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
            // 아무것도 입력하지 않았을 때 PleaseWritePanel을 활성화
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
                // 정상적인 입금 처리
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




    public void InvalidDeposit()  // Invalid 메서드
    {
        WarningPanel.SetActive(true);   // panel 활성화
    }

    public void OnClickOKButton()
    {
        // Panel의 OK버튼 클릭 시 Panel 비활성화.
        WarningPanel.SetActive(false);
        PleaseWritePanel.SetActive(false);
        InputMoneyField.text = "";  // 입력값 비우기

    }

    public void GoBackToMainScene()  // 뒤로가기 (메인씬 가기)
    {
        SceneManager.LoadScene("MainScene");
    }
}
