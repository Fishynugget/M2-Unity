using UnityEngine;
using System;

public class BumperHit : MonoBehaviour
{
    [SerializeField] private int bumperValue = 50;
    private ParticleSystem ps;
    [SerializeField] private int scoreValue = 100;
    public static event Action<Transform, int> onBumperHit;

    private void Start()
    {
        //Vraag het Particle System Component op als de game start en bewaar hem in je variabele, zodat je er later dingen mee kunt doen
        ps = GetComponent<ParticleSystem>();

        //zet je particle system stil! (? checkt of er wel een particle system is.)
        ps?.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) {
            onBumperHit?.Invoke(gameObject.transform, scoreValue);//bericht versturen dat er een bumper geraakt is. De tag en waarde sturen we mee
            //  Debug.Log("sdfg");
            onBumperHit?.Invoke(gameObject.transform, bumperValue);

            //zet je Particle System hem eerst weer stil voor het geval hij nog niet klaar was met de vorige loop
            ps?.Stop();

            //speel hem nu af vanaf het begin.
            ps?.Play();
        }
    }
}
