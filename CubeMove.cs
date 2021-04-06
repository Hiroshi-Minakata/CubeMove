using UnityEngine;

namespace toio
{
    public class CubeMove : MonoBehaviour
    {
        //DeveloperMat 1square(high=43, wide=43.5714285714)
        //https://d2air1d4eqhwg2.cloudfront.net/media/files/1fa512cd-858f-4f77-a3e0-241c1eb8213d.pdf

        CubeManager cubeManager;

        async void Start()
        {
            cubeManager = new CubeManager();
            await cubeManager.MultiConnect(1);
        }

        void Update()
        {
            if (cubeManager.synced)
            {
                cubeManager.navigators[0].Navi2Target(644, 250, maxSpd: 50).Exec();
            }
        }
    }
}