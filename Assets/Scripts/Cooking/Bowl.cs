using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour, IInteractableWithPlayerObject
{
    [Header("Dough")]
    [SerializeField]
    private Dough _dough;
    [SerializeField]
    private Transform _doughSpawnpoint;
    [Space(3)]
    [SerializeField]
    private Fridge _fridge;
    [SerializeField]
    private List<DoughIngridient.Type> _ingridientsInBowl;

    [SerializeField]
    private bool _hasWater = false;

    public bool HasWater { get => _hasWater; set => _hasWater = value; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out DoughIngridient ingridient))
        {
            if (other.TryGetComponent(out Egg egg) && egg.IsBroken == true)
                return;

            if (ingridient.TryGetComponent(out FridgeItem item))
                item.IsUsing = true;

            _ingridientsInBowl.Add(ingridient.CurrentType);
        }
        else
            _dough.Type = BakingType.Error;
    }

    private void OnTriggerExit(Collider other){
        if (other.TryGetComponent(out DoughIngridient ingridient)){
            _ingridientsInBowl.Remove(ingridient.CurrentType);

            if (ingridient.TryGetComponent(out FridgeItem item))
                item.IsUsing = false;
        }
        if (other.TryGetComponent(out Dough dough))
        {
            if (dough.CurrentState == Dough.State.Unrised)
            {
                dough.Grow();
            }
        }
    }

    public void TryMakeDough()
    {
        if (!_ingridientsInBowl.Contains(DoughIngridient.Type.Egg) || !_ingridientsInBowl.Contains(DoughIngridient.Type.Flour) || !_hasWater || !_ingridientsInBowl.Contains(DoughIngridient.Type.Yeast))
            return;

        _ingridientsInBowl.Clear();

        _fridge.UpdateFridge();
        Instantiate(_dough.gameObject, _doughSpawnpoint.position, _doughSpawnpoint.rotation);
        HasWater = false;
    }

    public void Interact(){
        TryMakeDough();
    }
}