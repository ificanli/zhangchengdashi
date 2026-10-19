using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
public class EventManagerFixture
{
    private readonly Dictionary<string, Action<object>> _eventWithObjectDictionary = new Dictionary<string, Action<object>>();
    private readonly Dictionary<string, Action<object>> _eventOnceObjectDictionary = new Dictionary<string, Action<object>>();
    public UniTask Init()
    {
        return UniTask.CompletedTask;
    }

    public void StartListening(string eventName, Action<object> listener)
    {
        if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
        {
            _eventWithObjectDictionary[eventName] += listener;
        }
        else
        {
            _eventWithObjectDictionary[eventName] = listener;
        }
    }

    public void StopListening(string eventName, Action<object> listener)
    {
        if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
        {
            _eventWithObjectDictionary[eventName] = eventListeners - listener;
        }
    }

    public void StartListeningOnce(string eventName, Action<object> listener)
    {
        if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
        {
            _eventOnceObjectDictionary[eventName] += listener;
        }
        else
        {
            _eventOnceObjectDictionary[eventName] = listener;
        }
    }

    public void StopListeningOnce(string eventName, Action<object> listener)
    {
        if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
        {
            _eventOnceObjectDictionary[eventName] = eventListeners - listener;
        }
    }

    public void TriggerEvent(string eventName, object parameter = null)
    {
        if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
        {
            eventListeners.Invoke(parameter);
        }

        if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> onceListeners) && onceListeners != null)
        {
            _eventOnceObjectDictionary.Remove(eventName);
            onceListeners.Invoke(parameter);
        }
    }

    public EventManagerFixture()
    {
    }
}