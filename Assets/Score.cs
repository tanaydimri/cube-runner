using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform == null)
        {
            return;
        }

        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
