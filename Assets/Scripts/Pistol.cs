using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private float _bulletSpeed = 20f;
    [SerializeField] private float _bulletLifeTime = 5f;   // secs before bullet is destroyed

    [SerializeField] private AudioClip _clip;
    private AudioSource _source;

    void Start()
    {
       _source = GetComponent<AudioSource>();
    }

    public void FireBullet()
    {
        GameObject bullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        _source.PlayOneShot(_clip);

        if(rb != null)
            rb.linearVelocity = _firePoint.forward * _bulletSpeed;

        // Destroyt the bullet after a set time
        Destroy(bullet, _bulletLifeTime);
    }
}
