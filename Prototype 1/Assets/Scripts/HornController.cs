using UnityEngine;

public class HornController : MonoBehaviour
{
    // Korna sesi çalacak AudioSource bileşenini Inspector'dan atayacağız.
    public AudioSource HornAudio;

    void Update()
    {
        // Spacebar tuşuna basıldığında (tuşa ilk basıldığı an) kontrolü
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Atama yapılıp yapılmadığını kontrol et.
            if (HornAudio != null)
            {
                // Hata ayıklama mesajı: Spacebar'ın algılandığını kontrol etmek için.
                Debug.Log("HornController: Spacebar detected, horn playing!");

                // Ses zaten çalmıyorsa başlat.
                if (!HornAudio.isPlaying)
                {
                    HornAudio.Play();
                }
            }
            else
            {
                // Hata ayıklama mesajı: Eger AudioSource atanmamışsa uyarı ver.
                Debug.LogError("HornController: HornAudio (AudioSource) değişkeni Inspector'da atanmamış!");
            }
        }
    }
}