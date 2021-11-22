using UnityEngine;

public class Rock : MonoBehaviour
{
    float speed = -0.2f;

    private void Start()
    {
        Destroy(gameObject, 3);

        transform.position = new Vector2(transform.position.x,
        Random.Range(transform.position.y + 2, transform.position.y - 2));
    }

    private void FixedUpdate() => transform.Translate(new Vector3(speed, 0));

    public void ChangeSpeed(float value) => speed = value;
}