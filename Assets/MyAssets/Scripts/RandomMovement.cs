using UnityEngine;

public class RandomMovement : MonoBehaviour
{
 
    Vector3 originalPosition;
    Vector3 newPosition;
    float counter = 0f;
    [SerializeField] float updateRate = 0.1f;
    [SerializeField] float maxDisplacement = 0.01f;
    [SerializeField] float interpolationSpeed = 10f;

    void Start()
    {
         originalPosition = transform.position;
         newPosition = originalPosition;
    }
    void Update()
    {

        counter += Time.deltaTime;

         transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*interpolationSpeed);

        if (counter >= updateRate)
        {
             newPosition = originalPosition + RandomPosition();
            counter = 0f;
        }
    }

    Vector3 RandomPosition()
    {
        float x = Random.Range(0f, maxDisplacement),
         y = Random.Range(0f, maxDisplacement),
          z = Random.Range(0f, maxDisplacement);

        return new Vector3(x, y, z);
    }
}
