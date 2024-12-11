using System;
using System.Collections;
using System.Linq;
using GameScripts;
using Players;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class FortuneWheel : MonoBehaviour
{
    public Transform wheelTransform; // Reference to the wheel's Transform
    public float spinDuration = 3.0f; // Duration of the spin in seconds
    public float spinSpeed = 500.0f; // Base spin speed
    public UnityEvent OnSpinComplete { get; private set; }

    // Get all categories.
    private readonly Category[] categories = { Category.DeepDives, Category.FutureYou, Category.ClicksAndGiggles, Category.MindMatters };

    private void Awake()
    {
        OnSpinComplete = new UnityEvent();
    }
    
    public void SpinWheel()
    {
        StartCoroutine(SpinAndSelect());
    }

    private IEnumerator SpinAndSelect()
    {
        float elapsedTime = 0f;
        float spinSpeedWithOffset = spinSpeed + Random.Range(0f, 100f);
        float currentSpeed = spinSpeedWithOffset;

        while (elapsedTime < spinDuration)
        {
            float deltaTime = Time.deltaTime;
            elapsedTime += deltaTime;

            // Spin the wheel
            wheelTransform.Rotate(0, 0, -currentSpeed * deltaTime);

            // Gradually slow down the spin
            currentSpeed = Mathf.Lerp(spinSpeedWithOffset, 0, elapsedTime / spinDuration);

            yield return null;
        }

        float segmentAngle = 360f / categories.Length;
        float finalAngle = wheelTransform.eulerAngles.z;
        int selectedIndex = Mathf.FloorToInt((finalAngle % 360f) / segmentAngle) % categories.Length;

        // Correct the final angle to align exactly
        // float correctedAngle = selectedIndex * segmentAngle;
        // wheelTransform.eulerAngles = new Vector3(0, 0, correctedAngle);

        PlayersManager.Instance.CurrentCategory = categories[selectedIndex];
        OnSpinComplete?.Invoke();
    }
}

