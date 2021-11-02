using UniRx;

public interface IHeroe
{
    ReactiveProperty<int> Health { get; }
}