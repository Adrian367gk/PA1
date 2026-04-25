using UnityEngine;

public class F : MonoBehaviour
{
    public RectTransform sadFace;

    private bool activated = false;

    void Start()
    {
        sadFace.gameObject.SetActive(false);
    }

    void Update()
    {
        if (activated)
        {
            sadFace.anchoredPosition = Vector2.Lerp(
                sadFace.anchoredPosition,
                Vector2.zero,
                Time.deltaTime * 5f
            );
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (activated) return;

        if (other.CompareTag("Hazard"))
        {
            activated = true;
            sadFace.gameObject.SetActive(true);

            sadFace.anchoredPosition = new Vector2(0, Screen.height);
        }
    }
}