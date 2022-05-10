using UnityEngine;
using UnityEngine.UI;

public class specialAttackTimer : MonoBehaviour
{
    public static bool allowInputs;

    public Slider countdownBar;
    private bool countDown = true;

    public float refillTime = 10;

    public GameObject specialAttackTimerIMG;

    private void Start()
    {
        //Set the max value to the refill time
        countdownBar.maxValue = refillTime;
        countdownBar.value = refillTime;
    }

    private void Update()
    {
        if (countdownBar.value == 10)
        {
            countdownBar.fillRect.GetComponent<Image>().color = new Color(0.4f, 0.6f, 1f, 1f);
            if (Input.GetButtonDown("Fire1"))
            {
                countdownBar.value = 0;
                countdownBar.fillRect.GetComponent<Image>().color = new Color(1f, 0.6f, 0.6f, 1f);
            }
        }

        if (countdownBar.maxValue != refillTime)
            countdownBar.maxValue = refillTime;

        countdownBar.value += Time.deltaTime;

        //If we are at 0, start to refill
        if (countdownBar.value <= 0)
        {
            countDown = false;
            allowInputs = false;
        }
        else if (countdownBar.value >= refillTime)
        {
            countDown = true;
            allowInputs = true;
        }
    }
}
