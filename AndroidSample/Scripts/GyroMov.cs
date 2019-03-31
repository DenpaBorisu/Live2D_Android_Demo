
// GyroMov
// Moves a background and a foreground, relative to the movement of the phone and the magnetic north

using UnityEngine;
using UnityEngine.UI;

public class GyroMov : MonoBehaviour
{
	private bool gyroEnabled;
	private Gyroscope gyro;

	// Background to be used
	public GameObject background;
	// Foreground to be used
	public GameObject foreground;

	private void Start()
	{
		// Enable gyrorscope on phone
		gyroEnabled = EnableGyro();
	}

	private bool EnableGyro()
	{
		if(SystemInfo.supportsGyroscope)
		{
			gyro = Input.gyro;
			gyro.enabled = true;
			return true;
		}
		return false;
	}

    void Update()
    {
    	// If gyro was succesfully enabled
    	if(gyroEnabled)
    	{
    		// Move the background and foreground according to the movement of the phone relative to the magnetic north
    		background.transform.position = new Vector3(-Mathf.Abs(gyro.attitude[1]*4),background.transform.position.y,background.transform.position.z);
    		foreground.transform.position = new Vector3(Mathf.Abs(gyro.attitude[1]*2),foreground.transform.position.y,foreground.transform.position.z);
    	}
    }
}
