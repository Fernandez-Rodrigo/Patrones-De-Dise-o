using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternsMenu : MonoBehaviour
{
    [SerializeField] private Button _factory;
    [SerializeField] private Button _builder;
    [SerializeField] private Button _volver;
    [SerializeField] private GameObject _canvasGroup;

    MediatorMenu _mediator;

    private void Awake()
    {
        _volver.onClick.AddListener(() => _mediator.GoToMainMenu());
        _factory.onClick.AddListener(() => _mediator.GoToFactoryScene());
        _builder.onClick.AddListener(() => _mediator.GoToBuilderScene());
    }

    public void Configure(MediatorMenu mediator)
    {
        _mediator = mediator;
    }
    public void Show()
    {

        _canvasGroup.SetActive(true);
    }

    public void Hide()
    {

        _canvasGroup.SetActive(false);
    }

}
