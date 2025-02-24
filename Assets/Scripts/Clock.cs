using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    //Change Awake to Update in order for the code to maintain current time
    private void Update()
    {
        //Debug.Log(DateTime.Now.Hour);

        //Variable to utilize for hours, minutes, seconds
        //Repeatedly calling datetime.now for each arm could result in conflicting times 
        TimeSpan time = DateTime.Now.TimeOfDay;

        //Takes parameters for rotation, utilize x,y,z
        //we will be moving across the z axis
        //Add onto the rotation DatimeTime.Now.Hour and multiply by -30 for the rotation, -6 for the minute and second hand

        hoursPivot.localRotation = Quaternion.Euler(0f,0f,(hoursToDegrees * (float)time.TotalHours));

        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, (minutesToDegrees * (float)time.TotalMinutes));

        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, (secondsToDegrees * (float)time.TotalSeconds));
    }

}
