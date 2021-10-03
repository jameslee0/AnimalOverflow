using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public float speed;
    private Transform player;
    private PlayerController user;
    public GameObject animations;
    private AudioSource audios;
    public AudioClip song;

    void Start()
    {
        user = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(animations, transform.position, Quaternion.identity);
            user.health--;
            Debug.Log(user.health);
            Destroy(gameObject);
        }
        if (other.CompareTag("Meat"))
        {
            Instantiate(animations, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreCounter.scoreValue += 1;
            SoundManager.PlaySound(UnityEngine.Random.Range(1,4).ToString());
        }
    }
}
