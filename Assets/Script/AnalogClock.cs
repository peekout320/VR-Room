using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    //長針、短針、秒針のTransform
    [SerializeField]
    private Transform hourHand;
    [SerializeField]
    private Transform minuteHand;
    [SerializeField]
    private Transform secondHand;

    //１ティックで動く各針の角度
    private float hourAngle = 30;
    private float minuteAngle = 6;
    private float secondAngle = 6;


    // Update is called once per frame
    void Update()
    {
        //現在時刻を取得
        var time = DateTime.Now;

        float hour = time.Hour;
        float minute = time.Minute;
        float second = time.Second;

        //各時間に対応した角度を取得
        float nowHour = hourAngle * hour;
        float nowMinute = minuteAngle * minute;
        float nowSecond = secondAngle * second;

        //各針のRotationを更新
        hourHand.localRotation = Quaternion.Euler(nowHour, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(nowMinute, 0, 0);
        secondHand.localRotation = Quaternion.Euler(nowSecond, 0, 0);
    }
}
