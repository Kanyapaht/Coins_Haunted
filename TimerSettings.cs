using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSettings : MonoBehaviour
{
    public Text TextTimer;
    public float Waktu = 10;// 01.30

    public bool GameAktif = true;
    public GameObject canvasKalah;

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);// 01
        int Detik = Mathf.FloorToInt(Waktu % 60);//30
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    float s;

    private void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Over");
            canvasKalah.SetActive(true);
            GameAktif = false;
        }


        SetText();
    }

}





