using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Services.Scene
{
    public class SceneLoader
    {
        public void LoadScene(int sceneIndex, Action onLoad = null) => LoadSceneAsync(sceneIndex, onLoad);

        private async void LoadSceneAsync(int sceneIndex, Action onLoad = null)
        {
            if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
            {
                onLoad?.Invoke();
                return;
            }
            
            AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(sceneIndex);
            while (!waitNextScene.isDone)
            {
                await UniTask.Yield();
            }
			
            onLoad?.Invoke();
        }
    }
}