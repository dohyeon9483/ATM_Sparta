using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void GoToDepositScene()
    {
        SceneManager.LoadScene("DepositScene");
    }

    public void GoToWithdrawalScene()
    {
        SceneManager.LoadScene("WithdrawalScene");
    }

    public void GoBackToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}