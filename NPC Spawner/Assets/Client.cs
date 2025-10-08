using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void SpawnVillagers()
    {
        m_SpawnerNPC.SpawnVillagers();
    }
}
