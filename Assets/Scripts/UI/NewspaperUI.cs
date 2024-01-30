using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NewspaperUI : MonoBehaviour, IInteractableWithPlayerObject
{
    [Header("Newspaper Settings")]
    [SerializeField]
    private GameObject _newspaperSetObj;
    [SerializeField, Range(2, 5)]
    private int _articleNumber;
    private Newspaper[] _newspaperList;
    private List<Article> _articleSet = new List<Article>();
    private int _currentArticalID = 0;

    [Header("Audio Settings")]
    [SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private Vector2 _rangeNewspaperVolume = new(0.65f, 0.75f);
    [SerializeField]
    private Vector2 _rangeNewspaperPitch = new(0.8f, 1.1f);

    [Header("UI Elements")]
    [SerializeField]
    private GameObject _newspaperMenu;
    [SerializeField]
    private TextMeshProUGUI _title;
    [SerializeField]
    private TextMeshProUGUI _content;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _newspaperList = _newspaperSetObj.GetComponents<Newspaper>();

        System.Random random = new System.Random();
        int newspaperID = random.Next(0, _newspaperList.Length - 1);

        foreach (Article atc in _newspaperList[newspaperID].articleSet)
        {
            _articleSet.Add(atc);
        }

        for (int i = 0, randNum, length = _articleSet.Count - _articleNumber; i < length; i++)
        {
            randNum = random.Next(0, _articleSet.Count - 1);
            _articleSet.Remove(_articleSet[randNum]);
        }
    }

    public void SwitchLeft()
    {
        if (_currentArticalID == 0)
            _currentArticalID = _articleNumber - 1;
        else
            _currentArticalID--;
        UpdateUI();
    }

    public void SwitchRight()
    {
        if (_currentArticalID == _articleNumber - 1)
            _currentArticalID = 0;
        else
            _currentArticalID++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        _title.text = _articleSet[_currentArticalID].title;
        _content.text = _articleSet[_currentArticalID].content;

        if (!_audioSource.isPlaying)
        {
            _audioSource.volume = UnityEngine.Random.Range(_rangeNewspaperVolume.x, _rangeNewspaperVolume.y);
            _audioSource.pitch = UnityEngine.Random.Range(_rangeNewspaperPitch.x, _rangeNewspaperPitch.y);
            _audioSource.Play();
        }
    }

    public void Interact()
    {
        GameState.Singleton.SetUIState();
        _newspaperMenu.SetActive(true);
        UpdateUI();
    }

    public void CloseMenu()
    {
        _newspaperMenu.SetActive(false);
        GameState.Singleton.SetGameState();
    }
}