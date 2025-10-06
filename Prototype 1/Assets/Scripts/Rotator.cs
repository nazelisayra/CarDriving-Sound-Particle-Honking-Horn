using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 5f;

    [Header("Movement Settings")]
    public float movementAmplitude = 2f;
    public float movementFrequency = 1f;

    // Her nesne için rastgele bir başlangıç fazı (offset) tutar
    private float randomOffset;

    // Nesnenin başlangıç (merkez) pozisyonunu tutar
    private Vector3 startPosition;

    void Start()
    {
        // Başlangıç pozisyonunu kaydediyoruz.
        startPosition = transform.position;

        // BURASI ÖNEMLİ: Her nesne için 0 ile 2*PI (tam daire) arasında rastgele bir faz kayması belirliyoruz.
        // Bu, her nesnenin sinüs dalgasının farklı bir noktasından başlamasını sağlar.
        randomOffset = Random.Range(0f, 2f * Mathf.PI);
    }

    void Update()
    {
        // 1. DÖNDÜRME (Rotasyon)
        transform.Rotate(new Vector3(5, 5, 5) * Time.deltaTime * rotationSpeed);


        // 2. HAREKET (Salınım)

        // Time.time değerine, Start() metodunda rastgele belirlenen offset'i ekliyoruz.
        // Bu sayede, her nesnenin Sinüs fonksiyonu içindeki başlangıç noktası farklı olur.
        float sinInput = (Time.time * movementFrequency * 2 * Mathf.PI) + randomOffset;

        // Sinüs fonksiyonunu kullanarak -2 ile +2 arasında periyodik bir değer elde ediyoruz.
        float xOffset = Mathf.Sin(sinInput) * movementAmplitude;

        // Yeni pozisyonu hesaplayıp uyguluyoruz.
        Vector3 newPosition = startPosition;
        newPosition.x += xOffset;

        transform.position = newPosition;
    }
}