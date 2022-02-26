using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1.0f;
    public int totalBullets;

    private void Start()
    {
        GameEvents.current.onBulletCollected += CollectBullet;
        GameEvents.current.onFireABullet += FireBullet;
        GameEvents.current.BulletsCountUpdated(totalBullets);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Ended!!");
        }
    }

    private void CollectBullet()
    {
        totalBullets += 1;
        GameEvents.current.BulletsCountUpdated(totalBullets);
    }

    private void FireBullet()
    {
        if (totalBullets <= 0)
        {
            Debug.Log("No Bullets to Fire");
            return;
        }

        totalBullets -= 1;
        GameEvents.current.BulletFired();
        GameEvents.current.BulletsCountUpdated(totalBullets);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameHasEnded = false;
    }
}
