using UnityEngine;

public class Peggle : MonoBehaviour
{
    public int hitsToDestroy = 2;     // totaal aantal hits dat deze peg aankan
    public int pointsPerHit = 80;     // aantal punten dat één hit waard is

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // score toekennen
        ScoreManager.Instance.AddScore(pointsPerHit);

        // aftellen
        hitsToDestroy--;

        // check of de peg nu op is
        if (hitsToDestroy <= 0)
        {
            Destroy(gameObject, 0.25f);
            Destroy(this.gameObject, 0.25f);
        } 
    }

}
