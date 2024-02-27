using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private Renderer render;
    public float speed = 0.3f;
    private float offset;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
    }
}