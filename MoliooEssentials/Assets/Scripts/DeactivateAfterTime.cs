using System.Collections;
using UnityEngine;

public class DeactivateAfterTime : MonoBehaviour
{
    [SerializeField]
    private float _deactivationTime = 5f;

    private void OnEnable()
    {
        StartCoroutine(Deactivate());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(_deactivationTime);
        gameObject.SetActive(false);
    }
}
