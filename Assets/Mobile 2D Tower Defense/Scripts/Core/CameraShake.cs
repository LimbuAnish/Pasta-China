using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 0.5f; // Duration of the shake
    public float shakeMagnitude = 0.1f; // Magnitude of the shake
    private Coroutine shakeCoroutine;
    private bool isShaking = false; // Flag to check if shake is active

    public void TriggerShake()
    {
        if (!isShaking) // Start shake only if not already shaking
        {
            shakeCoroutine = StartCoroutine(Shake());
        }
    }

    public void StopShake()
    {
        if (shakeCoroutine != null)
        {
            StopCoroutine(shakeCoroutine);
            shakeCoroutine = null;
        }
        isShaking = false; // Reset the shaking flag
    }

    private IEnumerator Shake()
    {
        isShaking = true; // Set the flag to indicate shake is in progress
        float elapsedTime = 0f;

        while (elapsedTime < shakeDuration)
        {
            float offsetX = Random.Range(-1f, 1f) * shakeMagnitude;
            float offsetY = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.position = new Vector3(transform.position.x + offsetX, transform.position.y + offsetY, transform.position.z);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isShaking = false; // Reset the flag
        shakeCoroutine = null; // Clear the coroutine reference
    }
}
