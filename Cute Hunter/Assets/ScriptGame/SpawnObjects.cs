using UnityEngine;
[System.Serializable]
public sealed class SpawnObjects : MonoBehaviour
{
    
    public string nombre;
    public GameObject gameobject;
    public float timeSpawn;
    public float timer;
    public SpawnObjects[] listObjets;

    public Transform[] pointsDeSpawn;

    void Update()
    {
        if (pointsDeSpawn.Length == 0) return;

        foreach (SpawnObjects obj in listObjets)
        {
            if (obj.gameobject == null) continue;

            obj.timer += Time.deltaTime;
            if (obj.timer >= obj.timeSpawn)
            {
                Spawn(obj);
                obj.timer = 0;
            }
        }
    }
    void Spawn(SpawnObjects config)
    {
        int point = Random.Range(0, pointsDeSpawn.Length);
        Transform pointselection = pointsDeSpawn[point];

        Instantiate(config.gameobject, pointselection.position, pointselection.rotation);
    }
}