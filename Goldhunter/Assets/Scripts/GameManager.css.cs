using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

	private float _timeRemaining;

	public float TimeRemaining
	{
		get { return TimeRemaining;}
		set {_timeRemaining = value;}
	}

	private float maxTime = 5 * 60; // Seconds

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
