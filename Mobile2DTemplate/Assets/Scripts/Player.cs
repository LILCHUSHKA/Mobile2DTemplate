using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    GameObject deathPanel;

    Vector2 startPos;

    float ySpeed = -0.03f, farmerYSpeed;

    private void Awake() =>  deathPanel = GameObject.FindObjectOfType<DeathPanel>().gameObject;

    private void Start()
    {
        startPos = transform.position;
        farmerYSpeed = ySpeed;

        StartCoroutine(Timer());
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) ySpeed = Mathf.Abs(ySpeed);
        else ySpeed = farmerYSpeed;
    }

    private void FixedUpdate() => transform.Translate(new Vector3(0, ySpeed));

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = startPos;
        deathPanel.SetActive(true);

        Rock[] rocks = GameObject.FindObjectsOfType<Rock>();

        for (int i = 0; i < rocks.Length; i++) Destroy(rocks[i].gameObject);
    }

    IEnumerator Timer()
    {
        float maxSpeed = -0.15f;

        while (ySpeed != maxSpeed)
        {
            yield return new WaitForSeconds(15);

            farmerYSpeed -= 0.03f;
            ySpeed = farmerYSpeed;
        }
    }

    /*Для управления через кнопку - цепляем это на картинку
    [SerializeField] Player player;

    public void OnPointerUp(PointerEventData eventData)
    {
        player.ySpeed = Mathf.Abs(ySpeed);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        player.ySpeed = farmerYSpeed;
    }*/
}