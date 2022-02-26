using UnityEngine;
using TMPro;

public class updateBulletsCount : MonoBehaviour
{
    public TextMeshProUGUI bulletsCountText;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onBulletsCountUpdated += OnBulletsCountUpdated;
    }

    private void OnBulletsCountUpdated(int bulletCount)
    {
        bulletsCountText.text = bulletCount.ToString();
    }
}
